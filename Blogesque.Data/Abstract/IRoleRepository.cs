using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogesque.Entities.Concrete;
using Blogesque.Shared.Data.Abstract;

namespace Blogesque.Data.Abstract
{
    public interface IRoleRepository : IEntityRepository<Role>
    {
    }
}
