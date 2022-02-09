using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogesque.Entities.Concrete;
using Blogesque.Shared.Entities.Abstract;

namespace Blogesque.Entities.Dtos
{
    public class ArticleDto : DtoGetBase
    {
        public Article Article { get; set; }
    }
}
