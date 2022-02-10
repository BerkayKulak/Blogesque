using AutoMapper;
using Blogesque.Entities.Concrete;
using Blogesque.Entities.Dtos;

namespace Blogesque.Mvc.Automapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserAddDto, User>();
        }
    }
}
