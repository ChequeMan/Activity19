using Catalogo.Modelos;

namespace Catalogo.Repositorio
{
    public interface IRepositorioProductos
    {
        Task<List<Producto>> GetAll();
        Task<Producto?> Get(int id);
        Task<Producto> Add(Producto producto);
        Task Update(int id, Producto producto);
        Task Delete(int id);
    }
}
