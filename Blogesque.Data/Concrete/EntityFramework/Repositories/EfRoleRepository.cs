using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogesque.Data.Abstract;
using Blogesque.Entities.Concrete;
using Blogesque.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Blogesque.Data.Concrete.EntityFramework.Repositories
{
    public class EfRoleRepository : EfEntityRepositoryBase<Role>, IRoleRepository
    {
        public EfRoleRepository(DbContext context) : base(context)
        {
        }
    }
}
