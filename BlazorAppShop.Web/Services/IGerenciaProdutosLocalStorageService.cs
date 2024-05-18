using BlazorAppShop.Models.DTOs;

namespace BlazorAppShop.Web.Services;

public interface IGerenciaProdutosLocalStorageService
{
    Task<IEnumerable<ProdutoDto>> GetCollection();
    Task RemoveCollection();
}
