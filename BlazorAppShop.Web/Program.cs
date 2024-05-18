using BlazorAppShop.Web;
using BlazorAppShop.Web.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ICarrinhoCompraService, CarrinhoCompraService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

var baseUrl = "https://localhost:7100/";
builder.Services.AddScoped(opts => new HttpClient
{
    BaseAddress = new Uri(baseUrl)
});

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IGerenciaCarrinhoItensLocalStorageService, GerenciaCarrinhoItensLocalStorageService>();
builder.Services.AddScoped<IGerenciaProdutosLocalStorageService, GerenciaProdutosLocalStorageService>();


await builder.Build().RunAsync();
