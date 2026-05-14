using ModelContextProtocol.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McpServer1.Tools
{
    [McpServerToolType]
    public class WeatherTool
    {
        [McpServerTool]
        [Description("Gets Weather information for a specified location.")]
        public string GetWeather(string city)
        {
            return $"Weather in {city}: Sunny, 25°C";
        }
    }
}
