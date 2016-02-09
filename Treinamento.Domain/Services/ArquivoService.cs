using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Repositories;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Domain.Services
{
    public class ArquivoService : ServiceBase<Arquivo>, IArquivoService
    {
        private readonly IArquivoRepository _arquivoRepository;

        public ArquivoService(IArquivoRepository arquivoRepository)
            :base(arquivoRepository)
        {
            _arquivoRepository = arquivoRepository;
        }
    }
}
