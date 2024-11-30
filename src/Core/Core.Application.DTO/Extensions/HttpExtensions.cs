﻿using Newtonsoft.Json;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.Core.Application.DTO.Seedwork.ValueObjects;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace Niu.Nutri.Core.Application.DTO.Extensions
{
    public static class HttpExtensions
    {
        public async static Task<T> OnInitializedAsync<T>(this HttpClient Http, string id)
            where T : EntityDTO, new()
        {
            try
            {
                try
                {
                    return (await Http.GetFromJsonAsync<GetHttpResponseDTO<T>>($"{new T().GetRoute()}?IdExternoEqual={id}"))?.Data;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                //ex.Redirect();
            }
            return null;
        }
        public async static Task<GetHttpResponseDTO> FindOneAsync(this HttpClient Http, string route, string query)
        {
            try
            {
                var testResult = await Http.GetAsync($"{route}?{query}");
                var content = await testResult.Content.ReadAsStringAsync();
                var test = JsonConvert.DeserializeObject<GetHttpResponseDTO>(await testResult.Content.ReadAsStringAsync());
                return test;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async static Task<GetHttpResponseDTO<T>> FindOneAsync<T>(this HttpClient Http, string route, string query)
        {
            try
            {
                var testResult = await Http.GetAsync($"{route}?{query}");
                var content = await testResult.Content.ReadAsStringAsync();
                var test = JsonConvert.DeserializeObject<GetHttpResponseDTO<T>>(await testResult.Content.ReadAsStringAsync());
                return test;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async static Task<GetHttpResponseDTO<T>> FindOneAsync<T>(this HttpClient Http, string query)
            where T : EntityDTO, new()
        {
            try
            {
                var testResult = await Http.GetAsync($"{new T().GetRoute()}?{query}");
                var content = await testResult.Content.ReadAsStringAsync();
                var test = JsonConvert.DeserializeObject<GetHttpResponseDTO<T>>(await testResult.Content.ReadAsStringAsync());
                return test;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async static Task<GetHttpResponseDTO<K>> SearchAsync<T,K>(this HttpClient Http, string route, string query = null)
            where T : IEntityDTO, new()
        {
            try
            {
                var url = $"{new T().GetRoute()}{(route.StartsWith('/') ? "" : @"/")}";
                var result = (await Http.GetAsync($"{url}{route}?{query}"));
                var content = await result.Content.ReadAsStringAsync();

                var test = JsonConvert.DeserializeObject<GetHttpResponseDTO<K>>(content);
                return test;
            }
            catch (Exception ex)
            {
                return GetHttpResponseDTO.ErrorTyped<K>(ex);
            }
        }

        public async static Task<GetHttpResponseDTO<List<T>>> SearchAsync<T>(this HttpClient Http, string route, string query = null)
            where T : IEntityDTO, new()
        {
            try
            {
                var url = $"{new T().GetRoute()}{(route.StartsWith('/') ? "" : @"/")}";
                var result = (await Http.GetAsync($"{url}{route}?{query}"));
                var content = await result.Content.ReadAsStringAsync();

                var test = JsonConvert.DeserializeObject<GetHttpResponseDTO<List<T>>>(content);
                return test;
            }
            catch (Exception ex)
            {
                return GetHttpResponseDTO.ErrorTyped<List<T>>(ex);
            }
        }

        public async static Task<GetHttpResponseDTO<List<T>>> SearchAsync<T>(this HttpClient Http, string? query = null)
            where T : IEntityDTO, new()
        {
            try
            {
                return (await Http.GetFromJsonAsync<GetHttpResponseDTO<List<T>>>($"{new T().GetSearchRoute()}?{query}"));
            }
            catch (HttpRequestException ex)
            {
                if (ex.HttpRequestError == HttpRequestError.ConnectionError)
                    return GetHttpResponseDTO.NotFound<List<T>>(ex.Message);

                return GetHttpResponseDTO.ErrorTyped<List<T>>(ex);
            }
            catch (Exception ex)
            {
                return GetHttpResponseDTO.ErrorTyped<List<T>>(ex);
            }
        }

        public async static Task<K[]> SelectAsync<T, K>(this HttpClient Http)
            where T : EntityDTO, new()
            where K : EntityDTO, new()
        {
            try
            {
                return (await Http.GetFromJsonAsync<GetHttpResponseDTO<K[]>>($"{new T().GetSelectRoute()}"))?.Data;
            }
            catch (Exception ex)
            {
                //ex.Redirect();
            }
            return null;
        }

        public async static Task<K[]> SummaryAsync<T, K>(this HttpClient Http, string? query = null)
            where T : EntityDTO, new()
            where K : EntityDTO, new()
        {
            try
            {
                return (await Http.GetFromJsonAsync<GetHttpResponseDTO<K[]>>($"{new T().GetSummaryRoute()}?{query}"))?.Data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

        public async static Task<K[]> SummaryAsync<T, K>(this HttpClient Http, Expression<Func<T, bool>> expressions)
            where T : IEntityDTO, new()
            where K : IEntityDTO, new()
        {
            try
            {
                var query = LambdaToFilterQueryString(expressions);
                return (await Http.GetFromJsonAsync<GetHttpResponseDTO<K[]>>($"{new T().GetSummaryRoute()}?{query}"))?.Data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

        public async static Task<GetHttpResponseDTO<int>> CountAsync<T>(this HttpClient Http, string? query = null)
            where T : IEntityDTO, new()
        {
            try
            {
                return await Http.GetFromJsonAsync<GetHttpResponseDTO<int>>($"{new T().GetCountRoute()}?{query}");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async static Task<GetHttpResponseDTO<K>> PostAsync<T, K>(this HttpClient Http, string uri, object model)
             where T : IEntityDTO, new()
        {
            string content = "";

            try
            {
                uri = new T().GetRoute() + "/" + uri;
                var result = await Http.PostAsJsonAsync(uri, model);
                content = await result.Content.ReadAsStringAsync();
                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<GetHttpResponseDTO<K>>(content);
                    }
                    catch (Exception ex)
                    {
                        return GetHttpResponseDTO.Error<K>(result.StatusCode, new string[] { ex.Message, ex.InnerException?.Message ?? "General Error" });
                    }
                    throw new Exception(await result.Content.ReadAsStringAsync());
                }

                return JsonConvert.DeserializeObject<GetHttpResponseDTO<K>>(content);
            }
            catch (Exception ex)
            {
                return GetHttpResponseDTO.ErrorTyped<K>(ex);
            }
        }

        public async static Task<GetHttpResponseDTO> PostAsync<T>(this HttpClient Http, string uri, object model)
             where T : IEntityDTO, new()
        {
            string content = "";

            try
            {
                uri = new T().GetRoute() + "/" + uri;
                var result = await Http.PostAsJsonAsync(uri, model);
                content = await result.Content.ReadAsStringAsync();
                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<GetHttpResponseDTO>(content);
                    }
                    catch (Exception ex)
                    {
                        return GetHttpResponseDTO.Error(result.StatusCode, new string[] { ex.Message, ex.InnerException?.Message ?? "General Error" });
                    }
                    throw new Exception(await result.Content.ReadAsStringAsync());
                }

                return JsonConvert.DeserializeObject<GetHttpResponseDTO>(content);
            }
            catch (Exception ex)
            {
                return GetHttpResponseDTO.Error(ex);
            }
        }

        public async static Task<GetHttpResponseDTO<DomainResponseDTO>> CreateAsync<T>(this HttpClient Http, T model)
            where T : IEntityDTO, new()
        {
            string content = "";

            try
            {
                var result = await Http.PostAsJsonAsync(new T().GetRoute(), model);
                content = await result.Content.ReadAsStringAsync();
                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<GetHttpResponseDTO<DomainResponseDTO>>(content);
                    }
                    catch (Exception ex)
                    {
                        return GetHttpResponseDTO.Error<DomainResponseDTO>(result.StatusCode, new string[] { ex.Message, ex.InnerException?.Message ?? "General Error" });
                    }
                    throw new Exception(await result.Content.ReadAsStringAsync());
                }

                return JsonConvert.DeserializeObject<GetHttpResponseDTO<DomainResponseDTO>>(content);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message + content);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + content);
            }
        }

        public static async Task<GetHttpResponseDTO<T>> DeleteEntityAsync<T>(this HttpClient http, Expression<Func<T, bool>> query)
            where T : IEntityDTO, new()
        {
            try
            {
                var test = query.LambdaToQueryString();
                var result = await http.DeleteAsync($"{new T().GetDeleteRoute()}?{test}");

                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new Exception(await result.Content.ReadAsStringAsync());
                }

                var content = await result.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<GetHttpResponseDTO<T>>(content);

                return response;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async static Task<GetHttpResponseDTO> UploadImage(this HttpClient httpClient, string fileNameAndPath, byte[] image)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("/api/images/", new ImageFileInfoDTO { Image = image, Name = fileNameAndPath });

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Failed to upload file: {response.ReasonPhrase}");
                }

                var result = JsonConvert.DeserializeObject<GetHttpResponseDTO>(await response.Content.ReadAsStringAsync());
                return result;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public async static Task<GetHttpResponseDTO> UploadFile(this HttpClient httpClient, string fileNameAndPath, byte[] image)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("/api/files/", new ImageFileInfoDTO { Image = image, Name = fileNameAndPath });

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Failed to upload file: {response.ReasonPhrase}");
                }

                var result = JsonConvert.DeserializeObject<GetHttpResponseDTO>(await response.Content.ReadAsStringAsync());
                return result;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static string LambdaToFilterQueryString<T>(Expression<Func<T, bool>> expression)
        {
            var replacements = new Dictionary<string, string>();
            WalkExpression(replacements, expression);

            string body = expression.Body.ToString();

            foreach (var parm in expression.Parameters)
            {
                var parmName = parm.Name;
                var parmTypeName = parm.Type.Name;
                body = body.Replace(parmName + ".", parmTypeName + ".");
            }

            foreach (var replacement in replacements)
            {
                body = body.Replace(replacement.Key, replacement.Value);
            }

            return body;
        }

        private static void WalkExpression(Dictionary<string, string> replacements, Expression expression)
        {
            switch (expression.NodeType)
            {
                case ExpressionType.MemberAccess:
                    string replacementExpression = expression.ToString();
                    if (replacementExpression.Contains("value("))
                    {
                        string replacementValue = Expression.Lambda(expression).Compile().DynamicInvoke().ToString();
                        if (!replacements.ContainsKey(replacementExpression))
                        {
                            replacements.Add(replacementExpression, replacementValue);
                        }
                    }
                    break;

                case ExpressionType.GreaterThan:
                case ExpressionType.GreaterThanOrEqual:
                case ExpressionType.LessThan:
                case ExpressionType.LessThanOrEqual:
                case ExpressionType.OrElse:
                case ExpressionType.AndAlso:
                case ExpressionType.Equal:
                    var bexp = expression as BinaryExpression;
                    WalkExpression(replacements, bexp.Left);
                    WalkExpression(replacements, bexp.Right);
                    break;

                case ExpressionType.Call:
                    var mcexp = expression as MethodCallExpression;
                    foreach (var argument in mcexp.Arguments)
                    {
                        WalkExpression(replacements, argument);
                    }
                    break;

                case ExpressionType.Lambda:
                    var lexp = expression as LambdaExpression;
                    WalkExpression(replacements, lexp.Body);
                    break;

                case ExpressionType.Constant:
                    // Do nothing
                    break;

                default:
                    Trace.WriteLine("Unknown type");
                    break;
            }
        }
    }
}
