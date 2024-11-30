using CrossCutting.Application.Mail;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Domain.CrossCutting;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Entities;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Repositories;
using Niu.Nutri.Users.Enumerations;
using Niu.Nutri.Users.Identity;

namespace Niu.Nutri.Users.Domain.Aggregates.UsersAgg.CommandHandlers;

public partial class UserCommandHandler
{
    public async override Task<DomainResponse> OnBeforeUpdateAsync(User entity)
    {
        using var repo = this._serviceProvider.GetRequiredService<IUserProfileListRepository>();

        entity.Accesses = (await repo.FindAllAsync(x => x.UserId == entity.Id)).ToList();
        return await base.OnBeforeUpdateAsync(entity);
    }

    public override async Task<DomainResponse> OnUpdateAsync(User entity, User entityAfter)
    {
        //using var _emailSender = this._serviceProvider.GetRequiredService<IEmailSender>();
        //using var userManager = this._serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        //await CheckSendPasswordByMail(userManager, entity, _emailSender, entity.Id.ToString());

        entity.Accesses = entityAfter.Accesses;
        foreach (var item in entity.Accesses)
        {
            foreach (var profile in item.UserProfiles)
            {
                _userRepository.Attach(profile);
            }
        }

        foreach (var item in entity.Accesses)
        {
            if (item.Id == 0)
            {
                _userRepository.Added(item);
            }
        }

        return await base.OnUpdateAsync(entity, entityAfter);
    }

    public async override Task<DomainResponse> OnCreateAsync(User entity)
    {
        using var _emailSender = this._serviceProvider.GetRequiredService<IEmailSender>();
        using var userRepository = this._serviceProvider.GetRequiredService<IUserRepository>();

        var newUser = entity.ProjectedAs<ApplicationUser>();

        using var userManager = this._serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        var sManager = this._serviceProvider.GetRequiredService<SignInManager<ApplicationUser>>();

        if (entity.Id == 0)
        {
            //entity.UserName = newUser.UserName = new Random().Next(1000000, 9999999).ToString();
            entity.UserName ??= newUser.Email!;

            var identityUserCreationResult = await userManager.CreateAsync(newUser, entity.Password!);

            if (!identityUserCreationResult.Succeeded)
                return DomainResponse.Error(identityUserCreationResult.Errors?.ToDictionary(x => x.Code ?? "00", x => x.Description)!);

            entity.Id = entity.Contact.Id = newUser.Id;
            entity.NeedSendOnboardingMail = true;
        }

        using var userProfileRepo = this._serviceProvider.GetRequiredService<IUserProfileRepository>();
        UserProfile defaultProfile = null;

        if (entity.Accesses?.Count == 0)
        {
            defaultProfile = await userProfileRepo.FindAsync(x => x.Code == UserProfileTypes.USER);
            if (defaultProfile is null)
            {
                defaultProfile = new UserProfile
                {
                    Code = UserProfileTypes.USER,
                    Active = true,
                    RegisterDone = true,
                    InitialPage = "/",
                    Description = UserProfileTypes.USER
                };
                userProfileRepo.Add(defaultProfile);
                await userProfileRepo.UnitOfWork.CommitAsync();
            }
            entity.Accesses.Add(new UserProfileList
            {
                Active = true,
                UserId = newUser.Id,
                UserProfiles = [defaultProfile]
            });
        }
        else
        {
            entity.Accesses[0].UserProfiles[0] = await userProfileRepo.FindAsync(x => x.Id == entity.Accesses[0].UserProfiles[0].Id);
            this._userRepository.Added(entity.Accesses[0]);
        }

        entity.SelectedAccess = null;
        return DomainResponse.Ok();
    }

    private async Task CheckSendPasswordByMail(UserManager<ApplicationUser> userManager, User entity, IEmailSender _emailSender, string userId)
    {
        if (entity.NeedSendOnboardingMail == true && !string.IsNullOrWhiteSpace(entity.Contact?.Email))
        {
            var newUser = await userManager.FindByIdAsync(userId);
            var token = await userManager.GeneratePasswordResetTokenAsync(await userManager.FindByIdAsync(entity.Id.ToString()));
            var pwd = Guid.NewGuid().ToString().Split('-').First();
            var resulPwdResult = await userManager.ResetPasswordAsync(newUser, token, pwd);
            await _emailSender.SendEmailAsync(entity.Contact.Email!, "Bem vindo à Niu.Nutri", $"Seu Login: {entity.UserName} \nSua senha: {pwd}");
            entity.NeedSendOnboardingMail = false;
        }
    }

    public async override Task<DomainResponse> OnDeleteAsync(User entity)
    {
        using var userManager = this._serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        using var _emailSender = this._serviceProvider.GetRequiredService<IEmailSender>();

        var appUser = await userManager.FindByIdAsync(entity.Id.ToString());
        if (appUser != null)
        {
            var deleteResult = await userManager.DeleteAsync(appUser);
            if (deleteResult.Succeeded)
                Task.Run(async () => await _emailSender.SendEmailAsync(entity.Contact.Email!, "Conta deletada", "Sua conta foi deletada com sucesso."));
        }

        return DomainResponse.Ok();
    }
}
