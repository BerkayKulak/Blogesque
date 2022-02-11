using AutoMapper;
using Blogesque.Entities.ComplexTypes;
using Blogesque.Entities.Concrete;
using Blogesque.Entities.Dtos;
using Blogesque.Mvc.Helpers.Abstract;

namespace Blogesque.Mvc.Automapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile(IImageHelper imageHelper)
        {
            CreateMap<UserAddDto, User>().ForMember(dest => dest.Picture, opt => opt.MapFrom(x => imageHelper.Upload(x.UserName, x.PictureFile, PictureType.User, null)));
            CreateMap<User, UserUpdateDto>();
            CreateMap<UserUpdateDto, User>();
        }
    }
}
