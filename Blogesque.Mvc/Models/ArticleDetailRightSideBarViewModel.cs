using Blogesque.Entities.Concrete;
using Blogesque.Entities.Dtos;

namespace Blogesque.Mvc.Models
{
    public class ArticleDetailRightSideBarViewModel
    {
        public string Header { get; set; }
        public ArticleListDto ArticleListDto { get; set; }
        public User User { get; set; }
    }
}
