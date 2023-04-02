using CRUDBlazor.Models;

namespace CRUDBlazor.Services
{
    public interface IEmpresaService
    {
        Task Add(Empresa empresa);

        Task Update(Empresa empresa);

        Task Delete(Empresa empresa);

        Task<Empresa> GetBy(Guid id);

        Task<List<Empresa>> FindAll();
    }
}
