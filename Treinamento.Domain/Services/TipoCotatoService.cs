using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Repositories;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Domain.Services
{
    public class TipoCotatoService : ServiceBase<TipoContato>, ITipoContatoService
    {
        private readonly ITipoContatoRepository _tipoContatoRepository;

        public TipoCotatoService(ITipoContatoRepository tipoContatoRepository)
            :base(tipoContatoRepository)
        {
            _tipoContatoRepository = tipoContatoRepository;
        }
    }
}
