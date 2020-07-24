using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(Context.MeuDbContext db) : base(db) { }

        public async Task<Endereco> ObterEnderecoProFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                                     .FirstOrDefaultAsync(c => c.FornecedorId == fornecedorId);
        }
    }
}
