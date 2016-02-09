using System.Collections.Generic;
using System.Linq;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Repositories;

namespace Treinamento.Infraestructure.Data.Repositories
{
    public class ArquivoRepository : RepositoryBase<Arquivo>, IArquivoRepository
    {
        public IEnumerable<Arquivo> FindByNome(string nome)
        {
            return Db.Arquivo.Where(a => a.Nome == nome);
        }
    }
}
