using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Application
{
    public class ArquivoAppService : AppServiceBase<Arquivo>, IArquivoAppService
    {
        private readonly IArquivoService _arquivoService;

        public ArquivoAppService(IArquivoService arquivoService)
            :base(arquivoService)
        {
            _arquivoService = arquivoService;
        }
    }
}
