using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RightO.Models;

namespace RightO.DAL
{
    public class QuestionRepository : IQuestionRepository, IDisposable
    {
        private RightOEntities context;

        public QuestionRepository(RightOEntities context)
        {
            this.context = context;
        }
        public IEnumerable<Models.QuestionMaster> GetAllQuestionsBySubcategory(int subcategoryId)
        {
             return context.QuestionMasters.Where(l=>l.SubCategoryID == subcategoryId).ToList();
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