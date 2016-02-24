using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Application
{
    public class TipoContatoAppService : AppServiceBase<TipoContato>, ITipoContatoAppService
    {
        private readonly ITipoContatoService _tipoContatoService;

        public TipoContatoAppService(ITipoContatoService tipoContatoService)
            :base(tipoContatoService)
        {
            _tipoContatoService = tipoContatoService;
        }
    }
}
