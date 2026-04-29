using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McpServer1.Models
{
    public class McpContext
    {
        public string? FileName { get; set; }
        public string? Language { get; set; }
        public string? Code { get; set; }
        public string? Error { get; set; }
    }
}
