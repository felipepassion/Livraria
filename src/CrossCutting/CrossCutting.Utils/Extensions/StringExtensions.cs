using Newtonsoft.Json;
using System.Linq.Expressions;

namespace Niu.Nutri.CrossCuting.Infra.Utils.Extensions
{
    public static class StringExtensions
    {
        public static bool TryDeserializeJSON<T>(this string request, out T result)
            where T : class
        {
            if (!string.IsNullOrWhiteSpace(request))
            {
                try
                {
                    result = JsonConvert.DeserializeObject<T>(request.Replace("\r\n", "").Replace(@"\n", ""))!;
                    return result != null;
                }
                catch { }
            }

            result = null;
            return false;
        }

        public static Expression<Func<T, object>> GetPropertySelector<T>(this string propertyName)
        {
            if (string.IsNullOrWhiteSpace(propertyName)) throw new NullReferenceException(nameof(propertyName));
            var arg = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(arg, propertyName);
            //return the property as object
            var conv = Expression.Convert(property, typeof(object));
            var exp = Expression.Lambda<Func<T, object>>(conv, new ParameterExpression[] { arg });
            return exp;
        }

        public static Expression<Func<T, object>>[]? GetPropertyListSelector<T>(this string? propertyName)
        {
            if (propertyName == null) return null;

            var result = new List<Expression<Func<T, object>>>();
            if (propertyName != null)
            {
                foreach (var item in propertyName?.Split(","))
                {
                    result.Add(GetPropertySelector<T>(propertyName));
                }
            }
            return result.ToArray();
        }

        public static string FormatNumber(
            this string numberAsStr,
            int? min = null,
            int? max = null,
            bool allowSpecialNumberInputs = false)
        {
            if (!int.TryParse(numberAsStr, out var numberAsInt))
                return string.Empty;

            if (min.HasValue)
            {
                if (numberAsInt < min)
                {
                    return min.ToString();
                }
            }
            if (max.HasValue)
            {
                if (numberAsInt > max)
                    return max.ToString();
            }

            if (!allowSpecialNumberInputs && numberAsStr.ContainsSpecialNumberCharacters())
                return string.Empty;

            return numberAsStr;
        }

        public static bool ContainsSpecialNumberCharacters(this string str)
        {
            string[] specialChars = ["+", "e"];

            return str.Any(x => specialChars.Contains(x.ToString()));
        }
    }
}
