using AutoMapper;
using Blogesque.Entities.Dtos;
using Blogesque.Mvc.Areas.Admin.Models;

namespace Blogesque.Mvc.Automapper.Profiles
{
    public class ViewModelsProfile : Profile
    {
        public ViewModelsProfile()
        {
            CreateMap<ArticleAddViewModel, ArticleAddDto>();
        }
    }
}
