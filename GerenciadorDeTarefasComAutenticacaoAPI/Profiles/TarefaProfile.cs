using AutoMapper;
using GerenciadorDeTarefasComAutenticacaoAPI.Data.DTOs;
using GerenciadorDeTarefasComAutenticacaoAPI.Models;

namespace GerenciadorDeTarefasComAutenticacaoAPI.Profiles
{
    public class TarefaProfile : Profile
    {
        public TarefaProfile()
        {
            CreateMap<CreateTarefaDTO, Tarefa>();
            CreateMap<Tarefa, ReadTarefaDTO>();
            CreateMap<UpdateTarefaDTO, Tarefa>();
        }
    }
}
