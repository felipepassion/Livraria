using System.Text.Json.Serialization;

namespace Niu.Nutri.Core.Api.Queries
{
    public interface IQueryModel
    {
        public string? Selector { get; set; }
        public string? OrderBy { get; set; }
        public bool? OrderByDesc { get; set; }
        public bool? GetOnlySummary { get; set; }
        public bool IsOrSpecification { get; set; }
    }

    public class BaseQueryModel : IQueryModel
    {
        [JsonIgnore]
        public string? OrderBy { get; set; }
        [JsonIgnore]
        public string? Selector { get; set; }
        [JsonIgnore]
        public bool? OrderByDesc { get; set; }
        [JsonIgnore]
        public bool? GetOnlySummary { get; set; }
        [JsonIgnore]
        public bool IsOrSpecification { get; set; }
    }
}
