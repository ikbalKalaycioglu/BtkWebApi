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
            CreateMap<Book,BookDto>();
            CreateMap<Book, BookDtoForInsertion>().ReverseMap();
            CreateMap<UserForRegistirationDto, User>();
        }
    }
}
