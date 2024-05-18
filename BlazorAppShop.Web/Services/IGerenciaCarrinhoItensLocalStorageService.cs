using BlazorAppShop.Models.DTOs;

namespace BlazorAppShop.Web.Services;

public interface IGerenciaCarrinhoItensLocalStorageService
{
    Task<List<CarrinhoItemDto>> GetCollection();
    Task SaveCollection(List<CarrinhoItemDto> carrinhoItensDto);
    Task RemoveCollection();
}
