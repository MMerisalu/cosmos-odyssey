using BlazorWebApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWebApp.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddHttpClient<CosmosService>(client => client.BaseAddress = new Uri("Http://localhost:5222"));
builder.Services.AddHttpClient<CosmosService>(client => client.BaseAddress = new Uri("https://cosmosodysseyapp.azurewebsites.net"));

await builder.Build().RunAsync();
