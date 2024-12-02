using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;

namespace Niu.Nutri.Core.Application.Aggregates.Common
{
    public class BaseMiniController : ControllerBase
    {
        protected readonly IServiceProvider _scope;
        protected readonly ILogRequestContext _logRequestContext;

        public BaseMiniController(ILogRequestContext logRequestContext, IServiceProvider scope)
        {
            _scope = scope;
            _logRequestContext = logRequestContext;
        }
    }
}