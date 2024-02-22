using Libreria;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MySecondBlazorApp.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<IMyDataSpecial, MyClientDataSpecial>();

await builder.Build().RunAsync();
