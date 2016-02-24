using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Application
{
    public class StatusAppService : AppServiceBase<Status>, IStatusAppService
    {
        private readonly IStatusService _statusService;

        public StatusAppService(IStatusService statusService)
            :base(statusService)
        {
            _statusService = statusService;
        }
    }
}
