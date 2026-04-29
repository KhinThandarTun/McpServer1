using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McpServer1.Models
{
    public class McpRequest
    {
        public string? Prompt { get; set; }
        public McpContext? Context { get; set; }
    }
}
