using Catalogo.Modelos;
using Microsoft.EntityFrameworkCore;
namespace Catalogo.Repositorio
{
    public class RepositorioCarritos : IRepositorioCarritos
    {
    private readonly CatalogoDBContext _context;

    public RepositorioCarritos(CatalogoDBContext context)
    {
        _context = context;
    }

    public async Task<Carrito> Add(Carrito carrito)
    {
        await _context.Carritos.AddAsync(carrito);
        await _context.SaveChangesAsync();
        return carrito;
    }

    public async Task Delete(int id)
    {
        var carrito = await _context.Carritos.FindAsync(id);
        if (carrito != null)
        {
            _context.Carritos.Remove(carrito);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<Carrito?> Get(int id)
    {
        return await _context.Carritos.FindAsync(id);
    }

    public async Task<List<Carrito>> GetAll()
    {
        return await _context.Carritos.ToListAsync();
    }

    public async Task Update(int id, Carrito carrito)
    {
        var carritoactual = await _context.Carritos.FindAsync(id);
        if (carritoactual != null)
        {
            carritoactual.NombreUsuario = carrito.NombreUsuario;
            carritoactual.NombreProducto = carrito.NombreProducto;
            carritoactual.Cantidad = carrito.Cantidad;
            await _context.SaveChangesAsync();
        }
    }
}
}
