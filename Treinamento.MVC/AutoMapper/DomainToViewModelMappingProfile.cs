using AutoMapper;
using Treinamento.Domain.Entities;
using Treinamento.MVC.ViewModels;

namespace Treinamento.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ArquivoViewModel, Arquivo>().ReverseMap();
            Mapper.CreateMap<ContatoViewModel, Contato>().ReverseMap();
            Mapper.CreateMap<EnderecoViewModel, Endereco>().ReverseMap();
            Mapper.CreateMap<PessoaViewModel, Pessoa>().ReverseMap();
        }
    }
}