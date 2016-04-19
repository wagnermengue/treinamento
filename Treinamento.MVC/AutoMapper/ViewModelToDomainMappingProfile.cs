using AutoMapper;
using Treinamento.Domain.Entities;
using Treinamento.MVC.ViewModels;

namespace Treinamento.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Arquivo, ArquivoViewModel>().ReverseMap();
            Mapper.CreateMap<Contato, ContatoViewModel>().ReverseMap();
        }
    }
}