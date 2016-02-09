using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Repositories;

namespace Treinamento.Infraestructure.Data.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
    }
}
