using Catalogo.Modelos;

namespace Catalogo.Repositorio
{
    public interface IRepositorioCarritos
    {
        Task<List<Carrito>> GetAll();
        Task<Carrito?> Get(int id);
        Task<Carrito> Add(Carrito carrito);
        Task Update(int id, Carrito carrito);
        Task Delete(int id);
    }
}
