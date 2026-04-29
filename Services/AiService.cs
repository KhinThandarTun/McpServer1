using McpServer1.Models;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace McpServer1.Services
{
    public class AiService
    {
        private readonly HttpClient _httpClient;

        public AiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> SendAsync(McpRequest request)
        {
            var payload = new
                    {
                        model = "gpt-4.1",
                        input = new[]
                        {
                            new
                            {
                                role = "user",
                                content = request.Prompt
                            }
                        },
                    context = request.Context
                };

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, "https://api.openai.com/v1/responses");

            httpRequest.Headers.Authorization =
                new AuthenticationHeaderValue("Bearer", "");

            httpRequest.Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(httpRequest);
            return await response.Content.ReadAsStringAsync();

        }
    }
}
