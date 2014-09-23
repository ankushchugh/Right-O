using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RightO.Models;

namespace RightO.DAL
{
    public class CategoryRepository : ICategoryRepository, IDisposable
    {
        private RightOEntities context;

        public CategoryRepository(RightOEntities context)
        {
            this.context = context;
        }

        public IEnumerable<Models.CategoryMaster> GetCategories()
        {
            return context.CategoryMasters.ToList();
        }

        public Models.CategoryMaster GetCategoryByID(int categoryId)
        {
            return context.CategoryMasters.Find(categoryId);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public void Save()
        {
            context.SaveChanges();
        }
    }
}