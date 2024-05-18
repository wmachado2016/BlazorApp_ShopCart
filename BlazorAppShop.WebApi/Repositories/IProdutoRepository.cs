using BlazorAppShop.Models.Entities;

namespace BlazorAppShop.WebApi.Repositories;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> GetItens();
    Task<Produto> GetItem(int id);

    Task<IEnumerable<Produto>> GetItensPorCategoria(int id);
    Task<IEnumerable<Categoria>> GetCategorias();
}
