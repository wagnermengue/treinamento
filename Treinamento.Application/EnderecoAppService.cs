using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.Domain.Interfaces.Services;

namespace Treinamento.Application
{
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService enderecoService)
            :base(enderecoService)
        {
            _enderecoService = enderecoService;
        }
    }
}
