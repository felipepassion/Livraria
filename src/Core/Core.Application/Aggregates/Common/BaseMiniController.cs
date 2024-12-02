using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;

namespace Niu.Nutri.Core.Application.Aggregates.Common
{
    public class BaseMiniController : ControllerBase
    {
        protected readonly IServiceProvider _scope;
        protected readonly ILogRequestContext _logRequestContext;

        protected GetHttpResponseDTO<object> BadValidationRequest(ModelStateDictionary modelState)
        {
            var errors = modelState?.Values
                .Where(x => x.ValidationState == ModelValidationState.Invalid)
                .Select(x => string.Join(',', x.Errors?.Select(xx => xx.ErrorMessage)!))
                .ToArray();

            return GetHttpResponseDTO.BadRequest(errors ?? new string[] { "Unkown validation error." });
        }

        public BaseMiniController(ILogRequestContext logRequestContext, IServiceProvider scope)
        {
            _scope = scope;
            _logRequestContext = logRequestContext;
        }
    }
}