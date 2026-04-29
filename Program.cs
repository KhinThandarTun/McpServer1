using McpServer1.Services;
using McpServer1.Tools;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateApplicationBuilder(args);

// Configure all logs to go to stderr (stdout is used for the MCP protocol messages).
builder.Logging.AddConsole(o => o.LogToStandardErrorThreshold = LogLevel.Trace);

// Add the MCP services: the transport to use (stdio) and the tools to register.
//builder.Services
//    .AddMcpServer()
//    .WithStdioServerTransport()
//    .WithTools<RandomNumberTools>();

builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()   // input/output (console) - use the existing API name
    .WithTools<FixCodeTool>(); // specify the tool type parameter to satisfy the generic method

var app = builder.Build();

Console.WriteLine("MCP Server Started..."); // debug

app.Run();
