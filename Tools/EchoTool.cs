using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McpServer1.Tools
{
    public class EchoTool
    {
        public string Execute(string message)
        {
            return $"Echo: {message}";
        }
    }
}
