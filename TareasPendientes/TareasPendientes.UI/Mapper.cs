using AutoMapper;
using TareasPendientes.Models.DTO;
using TareasPendientes.Models.Models;

namespace TareasPendientes.UI
{
    public class Mapper : Profile
    {
        public Mapper() {
            CreateMap<TareaDTO, Tarea>();
        }
    }
}
