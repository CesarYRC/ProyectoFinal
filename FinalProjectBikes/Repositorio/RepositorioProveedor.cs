using FinalProjectBikes.Modelo;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectBikes.Repositorio
{
    public class RepositorioProveedor : IRepositorioProveedor
    {
        private readonly CatalogoDBContext _context;

        public RepositorioProveedor(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Proveedor> Add(Proveedor proveedor)
        {
            await _context.proveedor.AddAsync(proveedor);
            await _context.SaveChangesAsync();
            return proveedor;
        }

        public async Task Delete(int id)
        {
            var proveedor = await _context.proveedor.FindAsync(id);
            if (proveedor != null)
            {
                _context.proveedor.Remove(proveedor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Proveedor?> Get(int id)
        {
            return await _context.proveedor.FindAsync(id);
        }

        public async Task<List<Proveedor>> GetAll()
        {
            return await _context.proveedor.ToListAsync();
        }

        public async Task Update(int id, Proveedor proveedor)
        {
            var proveedoractual = await _context.proveedor.FindAsync(id);
            if (proveedoractual != null)
            {
                proveedoractual.NameProveedor = proveedor.NameProveedor;
                proveedoractual.DirectionProveedor = proveedor.DirectionProveedor;
                proveedoractual.PhoneNumberProveedor = proveedor.PhoneNumberProveedor;
                proveedoractual.ModelBikeProveedor = proveedor.ModelBikeProveedor;
                proveedoractual.PriceProveedor = proveedor.PriceProveedor;
                proveedoractual.AmountProveedor = proveedor.AmountProveedor;

                await _context.SaveChangesAsync();
            }
        }


    }
}
