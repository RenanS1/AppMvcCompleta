using Microsoft.EntityFrameworkCore;
using Ren.Business.Interfaces;
using Ren.Data.Context;
using Ren.IO.Business.Models;

namespace Ren.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(RenDbContext context) : base(context)
        {

        }
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}
