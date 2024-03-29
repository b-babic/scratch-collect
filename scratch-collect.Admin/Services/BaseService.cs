﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace scratch_collect.Admin.Services
{
    public static class BaseService
    {
        private static HttpClient _httpClient = new HttpClient();

        public static async Task<T> GetAsync<T>(string resourceUrl, Dictionary<string, string> parameters = null)
        {
            string getAsyncUrl = resourceUrl;

            if (parameters != null)
            {
                getAsyncUrl = BuildQueryParams(resourceUrl, parameters);
            }

            HttpResponseMessage response = await _httpClient.GetAsync(getAsyncUrl);
            T deserializedResponse = await DeserializeResponse<T>(response);

            return deserializedResponse;
        }

        public static async Task<T> PostAsync<T, T2>(string resourceUrl, T2 parameter)
        {
            var response = await _httpClient.PostAsync(resourceUrl, CreateJsonContent(parameter));

            T deserializedResponse = await DeserializeResponse<T>(response);
            return deserializedResponse;
        }

        public static async Task<T> PutAsync<T, T2>(string resourceUrl, T2 parameter)
        {
            var response = await _httpClient.PutAsync(resourceUrl, CreateJsonContent(parameter));

            T deserializedResponse = await DeserializeResponse<T>(response);

            return deserializedResponse;
        }

        public static async Task<bool> DeleteAsync(string resourceUrl)
        {
            var response = await _httpClient.DeleteAsync(resourceUrl);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static async Task<T> DeserializeResponse<T>(HttpResponseMessage response)
        {
            var jsonObject = await response.Content.ReadAsStringAsync();
            var deserializedResponse = JsonConvert.DeserializeObject<T>(jsonObject);

            return deserializedResponse;
        }

        private static string BuildQueryParams(string baseUrl, Dictionary<string, string> parameters)
        {
            var builder = new UriBuilder(baseUrl);
            var query = HttpUtility.ParseQueryString(builder.Query);

            foreach (var parameter in parameters)
            {
                if (parameter.Value != null)
                {
                    query[parameter.Key] = parameter.Value;
                }
            }

            builder.Query = query.ToString();

            return builder.ToString();
        }

        private static StringContent CreateJsonContent(object objValue)
        {
            string json = JsonConvert.SerializeObject(objValue);
            var httpStringContent = new StringContent(json, Encoding.UTF8, "application/json");
            return httpStringContent;
        }

        public static void UpdateAuthorizationHeader(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
    }
}