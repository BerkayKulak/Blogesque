using System.Collections.Generic;
using Blogesque.Entities.Concrete;

namespace Blogesque.Mvc.Areas.Admin.Models
{
    public class UserWithRolesViewModel
    {
        public User User { get; set; }
        public IList<string> Roles { get; set; }
    }
}
