using System.Collections.Generic;
using Blogesque.Entities.Concrete;

namespace Blogesque.Mvc.Models
{
    public class RightSideBarViewModel
    {
        public IList<Category> Categories { get; set; }
        public IList<Article> Articles { get; set; }
    }
}
