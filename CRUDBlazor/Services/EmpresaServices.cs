using CRUDBlazor.Data;
using CRUDBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDBlazor.Services
{
    public class EmpresaServices : IEmpresaService
    {
        private readonly AppDbContext dbContext;
        public EmpresaServices(AppDbContext appDbContext)
        {
            dbContext = appDbContext;
        }

        //metodos CRUD
        //Add
        public async Task Add(Empresa empresa)
        {
            await dbContext.AddAsync(empresa);
            await dbContext.SaveChangesAsync();
        }

        //Update
        public async Task Update(Empresa empresa)
        {
            dbContext.Update(empresa);
            await dbContext.SaveChangesAsync();
        }

        //Delete
        public async Task Delete(Empresa empresa)
        {
            dbContext.Remove(empresa);
            await dbContext.SaveChangesAsync();
        }

        //Retorna o detalhe da empresa -> passando id, retorna a empresa
        public async Task<Empresa> GetBy(Guid id)
        {
            var empresa = await dbContext.Empresas.FirstOrDefaultAsync(c => c.Id == id);

            return empresa;
        }

        public async Task<List<Empresa>> FindAll()
        {
            var empresas = await dbContext.Empresas.ToListAsync();

            return empresas;
        }


    }
}
