using AutoMapper;
using OnetoManyRelationship.cs.Dto;

namespace OnetoManyRelationship.cs
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<GetUser,User>();
            CreateMap<GetCharacter,Character>();
        }
    }
}
