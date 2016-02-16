using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Repositories;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Domain.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
            :base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
    }
}
