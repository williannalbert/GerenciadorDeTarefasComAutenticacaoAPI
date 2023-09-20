using AutoMapper;
using GerenciadorDeTarefasComAutenticacaoAPI.Data.DTOs;
using GerenciadorDeTarefasComAutenticacaoAPI.Models;

namespace GerenciadorDeTarefasComAutenticacaoAPI.Profiles
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile()
        {
            CreateMap<CreateCategoriaDTO, Categoria>();
            CreateMap<Categoria, ReadCategoriaDTO>();
            CreateMap<UpdateCategoriaDTO, Categoria>();
        }
    }
}
