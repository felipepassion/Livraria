﻿using System.Text;

namespace Niu.Nutri.CrossCuting.Infra.Utils.Extensions
{
    public static class QueryParamConverter
    {
        public static string ObjectToQueryString(this object obj, bool includeInitial = true)
        {
            if (obj == null)
                return string.Empty;

            var properties = obj.GetType().GetProperties();
            var stringBuilder = new StringBuilder();

            foreach (var property in properties)
            {
                var value = property.GetValue(obj, null);
                if (value != null)
                {
                    if (stringBuilder.Length > 0)
                        stringBuilder.Append("&");

                    stringBuilder.AppendFormat("{0}={1}", Uri.EscapeDataString(property.Name), Uri.EscapeDataString(value.ToString()));
                }
            }

            var result = stringBuilder.ToString();
            
            if(includeInitial && !string.IsNullOrWhiteSpace(result))
                result = "?" + result;
            
            return result;
        }
    }
}
