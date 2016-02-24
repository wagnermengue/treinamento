using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Application
{
    public class PrioridadeAppService : AppServiceBase<Prioridade>, IPrioridadeAppService
    {
        private readonly IPrioridadeService _prioridadeService;

        public PrioridadeAppService(IPrioridadeService prioridadeService)
            :base(prioridadeService)
        {
            _prioridadeService = prioridadeService;
        }
    }
}
