using AutoMapper;
using Entites.DataTransferObjects;
using Entites.Models;

namespace BtkWebApi.Utilites.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookDtoForUpdate, Book>();
        }
    }
}
