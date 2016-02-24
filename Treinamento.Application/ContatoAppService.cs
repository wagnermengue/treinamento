using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Application
{
    public class ContatoAppService : AppServiceBase<Contato>, IContatoAppService
    {
        private readonly IContatoService _contatoService;

        public ContatoAppService(IContatoService contatoService)
            :base(contatoService)
        {
            _contatoService = contatoService;
        }
    }
}
