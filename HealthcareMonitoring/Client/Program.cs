using HealthcareMonitoring.Client;
using HealthcareMonitoring.Shared.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBootstrapBlazor();
builder.Services.AddScoped<IAppContext, DefaultAppContext>();


builder.Services.AddHttpClient("HealthcareMonitoring.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("HealthcareMonitoring.ServerAPI"));

builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
