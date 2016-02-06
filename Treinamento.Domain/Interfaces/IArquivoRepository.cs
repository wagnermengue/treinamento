using System.Collections.Generic;
using Treinamento.Domain.Entities;

namespace Treinamento.Domain.Interfaces
{
    public interface IArquivoRepository : IRepositoryBase<Arquivo>
    {
        IEnumerable<Arquivo> FindByNome(string nome);
    }
}
