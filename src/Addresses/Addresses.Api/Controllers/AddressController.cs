using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Repositories;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;

namespace Niu.Nutri.Addresses.Api.Controllers;

public partial class AddressController
{
    [HttpGet("search/neighbours")]
    public async Task<GetHttpResponseDTO<object>> GetNeighbours(
        [FromQuery] string city,
        [FromQuery] string? neighbour = null,
        int? page = 0, int? size = 5)
    {
        var addressRepository = this._scope.GetRequiredService<IAddressRepository>();

        var neighbours = (await addressRepository.SearchAddressesByBairroAsync(
            groupBy: x => x.Bairro_Distrito,
            city: city,
            searchTerm: neighbour,
            skip: page * size,
            take: size))
        .Where(x => !string.IsNullOrWhiteSpace(x.Bairro_Distrito))
        .Select(x => x.Bairro_Distrito)?.Distinct()?.ToList();

        return GetHttpResponseDTO.Ok(neighbours ?? new());
    }

    [HttpGet("search/cities")]
    public async Task<GetHttpResponseDTO<object>> GetCities([FromQuery] string? city = null, int? page = 0, int? size = 5)
    {
        var addressRepository = this._scope.GetRequiredService<IAddressRepository>();

        var cities = (await addressRepository.SearchAddressesByLogradouroAsync(
            groupBy: x => x.Cidade_Localidade,
            searchTerm: city!,
            skip: page * size,
            take: size))
        .Where(x => !string.IsNullOrWhiteSpace(x.Cidade_Localidade))
        .Select(x => x.Cidade_Localidade).Distinct()?.ToList();

        return GetHttpResponseDTO.Ok(cities ?? new());
    }
}