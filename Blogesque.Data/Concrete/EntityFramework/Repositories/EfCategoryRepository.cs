﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogesque.Data.Abstract;
using Blogesque.Data.Concrete.EntityFramework.Contexts;
using Blogesque.Entities.Concrete;
using Blogesque.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Blogesque.Data.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }

        public async Task<Category> GetById(int categoryId)
        {
            return await ProgrammersBlogContext.Categories.SingleOrDefaultAsync(c => c.Id == categoryId);
        }

        private ProgrammersBlogContext ProgrammersBlogContext
        {
            get
            {
                return _context as ProgrammersBlogContext;
            }
        }
    }
}
