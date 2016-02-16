using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Repositories;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Domain.Services
{
    public class PrioridadeService : ServiceBase<Prioridade>, IPrioridadeService
    {
        private readonly IPrioridadeRepository _prioridadeRepository;

        public PrioridadeService(IPrioridadeRepository prioridadeRepository)
            :base(prioridadeRepository)
        {
            _prioridadeRepository = prioridadeRepository;
        }
    }
}
