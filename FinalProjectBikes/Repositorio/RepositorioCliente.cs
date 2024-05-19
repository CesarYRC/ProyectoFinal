using FinalProjectBikes.Modelo;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectBikes.Repositorio
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly CatalogoDBContext _context;

        public RepositorioCliente(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Proveedor> Add(Proveedor cliente)
        {
            await _context.cliente.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task Delete(int id)
        {
            var cliente = await _context.cliente.FindAsync(id);
            if (cliente != null)
            {
                _context.cliente.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Proveedor?> Get(int id)
        {
            return await _context.cliente.FindAsync(id);
        }

        public async Task<List<Proveedor>> GetAll()
        {
            return await _context.cliente.ToListAsync();
        }

        public async Task Update(int id, Proveedor cliente)
        {
            var clienteactual = await _context.cliente.FindAsync(id);
            if (clienteactual != null)
            {
                clienteactual.Name = cliente.Name;
                clienteactual.Email = cliente.Email;
                clienteactual.PhoneNumber = cliente.PhoneNumber;
                clienteactual.ModelBike = cliente.ModelBike;
                await _context.SaveChangesAsync();
            }
        }


    }
}
