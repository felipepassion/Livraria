using FluentValidation;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Microsoft.Extensions.Logging;

namespace Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators
{
    public class BaseValidator<T> : AbstractValidator<T>, IValidator<T>
        where T : EntityDTO
    {
        protected HttpClient _http;
        ILogger _logger;

        public BaseValidator()
        {
        }

        public BaseValidator(HttpClient db)
        {
            _http = db;
        }

        public void SetHttp(HttpClient db)
        {
            _http = db;
        }

        protected async Task<bool> BeUnique<K>(string? externalId, string name, string value, CancellationToken cancellationToken, string? query = null)
            where K : EntityDTO, new()
        {
            if (string.IsNullOrWhiteSpace(value)) return true;
            
            var str = $"{typeof(K).Name.Replace("DTO", "")}?{name}Equal={value}";
            var result = await _http.CountAsync<K>($"ExternalIdNotEqual={externalId}&{name.ToUpper()}Equal={value}&{query}");
            
            return result.Success;
        }
    }
}
