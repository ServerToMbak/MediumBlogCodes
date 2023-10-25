using AutoMapper;
using AutoMapper_DTO.DTO;
using AutoMapper_DTO.Model;

namespace AutoMapper_DTO.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //Source => Destination
            CreateMap<CommentDTO, Comment>().ReverseMap();
        }
    }
}
