using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RightO.Models;

namespace RightO.DAL
{
    public class SubCategoryRepository :ISubCategoryRepository, IDisposable 
    {
        private RightOEntities context;

        public SubCategoryRepository(RightOEntities context)
        {
            this.context = context;
        }
        public IEnumerable<Models.SubCategoryMaster> GetSubCategoriesByCategoryID(int categoryId)
        {
            return context.SubCategoryMasters.Where(l => l.CategoryID == categoryId).ToList();
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


        public IEnumerable<SubCategoryMaster> GetAllSubCategories()
        {
            return context.SubCategoryMasters.ToList();
        }
    }
}