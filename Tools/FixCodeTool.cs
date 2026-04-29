using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McpServer1.Tools
{
    public class FixCodeTool
    {
        private readonly HttpClient _http;

        public FixCodeTool(IHttpClientFactory factory)
        {
            _http = factory.CreateClient();
        }

        public async Task<string> Execute(string code)
        {
            // AI API call
            return "fixed code result";
        }
    }
}
