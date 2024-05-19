using FinalProjectBikes.Modelo;
    
namespace FinalProjectBikes.Repositorio
{
    public interface IRepositorioCliente
    {
        Task<List<Proveedor>> GetAll();
        Task<Proveedor?> Get(int id);
        Task<Proveedor> Add(Proveedor cliente);
        Task Update(int id, Proveedor cliente);   
        Task Delete(int id);
    }
}
