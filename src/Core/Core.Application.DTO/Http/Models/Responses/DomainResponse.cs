namespace Niu.Nutri.Core.Application.DTO.Http.Models.Responses
{
    public class DomainResponse
    {
        public Exception? Exception { get; set; }

        public DomainResponse()
        {
        }
        public DomainResponse(object? data)
        {
            Data = data;
        }

        public DomainResponse(Dictionary<string, string> errors)
        {
            foreach (var item in errors)
            {
                Errors.Add(item.Key ?? Guid.NewGuid().ToString(), item.Value);
            }
        }

        public DomainResponse(Exception ex)
        {
            AddError(ex.Message);
            if (ex.InnerException is not null)
                AddError(ex.InnerException.Message);
            Exception = ex;
        }

        public DomainResponse(params string[] errors)
        {
            errors = errors ?? new string[0];

            if (errors.Any())
            {
                try
                {
                    Errors = errors.ToDictionary(x => x ?? "error");
                }
                catch (Exception)
                {
                }
            }
        }

        public static DomainResponse Error(params string[] errors)
        {
            return new DomainResponse(errors);
        }
        public static DomainResponse Error(Dictionary<string, string> dict)
        {
            return new DomainResponse(dict);
        }
        public static DomainResponse Ok()
        {
            return new DomainResponse();
        }

        public void AddError(params string[] newErrors)
        {
            foreach (var item in newErrors)
            {
                Errors.Add(Guid.NewGuid().ToString(), item);
            }
        }

        public Dictionary<string, string> Errors { get; set; } = new Dictionary<string, string>();
        public object? Data { get; set; }
        public bool Success => Errors.Count == 0;
    }
}