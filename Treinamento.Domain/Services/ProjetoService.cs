using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Repositories;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Domain.Services
{
    public class ProjetoService : ServiceBase<Projeto>, IProjetoService
    {
        private readonly IProjetoRepository _projetoRepository;

        public ProjetoService(IProjetoRepository projetoRepository)
            :base(projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
    }
}
