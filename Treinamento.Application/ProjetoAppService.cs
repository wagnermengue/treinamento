using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Application
{
    public class ProjetoAppService : AppServiceBase<Projeto>, IProjetoAppService
    {
        private readonly IProjetoService _projetoService;

        public ProjetoAppService(IProjetoService projetoService)
            :base(projetoService)
        {
            _projetoService = projetoService;
        }
    }
}
