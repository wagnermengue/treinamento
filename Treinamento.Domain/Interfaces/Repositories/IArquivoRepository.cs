using System.Collections.Generic;
using Treinamento.Domain.Entities;

namespace Treinamento.Domain.Interfaces.Repositories
{
    public interface IArquivoRepository : IRepositoryBase<Arquivo>
    {
        IEnumerable<Arquivo> FindByNome(string nome);
    }
}
