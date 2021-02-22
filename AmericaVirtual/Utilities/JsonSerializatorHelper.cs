using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AmericaVirtual.Utilities
{
    public static class JsonSerializatorHelper<T>
    {

        public static async Task<List<T>> GetJsonListFromContent(string uri, HttpClient httpClient)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            request.Headers.TryAddWithoutValidation("some-header", "some-value");

            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

            if (response.IsSuccessStatusCode)
            {
                // perhaps check some headers before deserialising

                try
                {
                    var stringList = await response.Content.ReadAsStringAsync();
                    var test = JsonConvert.DeserializeObject<List<T>>(stringList);
                    return test;
                }
                catch (NotSupportedException) // When content type is not valid
                {
                    Console.WriteLine("The content type is not supported.");
                }
                catch (Newtonsoft.Json.JsonException e) // Invalid JSON
                {
                    Console.WriteLine("Invalid JSON.");
                }
            }

            return null;
        }

        public static async Task<T> GetJsonFromContent(string uri, HttpClient httpClient)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            request.Headers.TryAddWithoutValidation("some-header", "some-value");

            using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

            if (response.IsSuccessStatusCode)
            {
                // perhaps check some headers before deserialising

                try
                {
                    var stringObject = await response.Content.ReadAsStringAsync();
                    return System.Text.Json.JsonSerializer.Deserialize<T>(stringObject);
                }
                catch (NotSupportedException) // When content type is not valid
                {
                    Console.WriteLine("The content type is not supported.");
                }
                catch (Newtonsoft.Json.JsonException e) // Invalid JSON
                {
                    Console.WriteLine("Invalid JSON.");
                }
            }

            return default(T);
        }

    }
}
