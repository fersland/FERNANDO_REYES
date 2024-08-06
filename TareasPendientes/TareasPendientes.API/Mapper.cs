using AutoMapper;
using TareasPendientes.Models.DTO;
using TareasPendientes.Models.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace TareasPendientes.API
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<TareaDTO, Tarea>();
        }
    }
}
