using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RightO.Models;

namespace RightO.DAL
{
    public class TestimonialRepository : ITestimonialRepository, IDisposable
    {
        private RightOEntities context;

        public TestimonialRepository(RightOEntities context)
        {
            this.context = context;
        }
        public IEnumerable<Models.TestimonialHistory> GetAllTestimonials()
        {
            return context.TestimonialHistories.ToList();
        }

        public Models.TestimonialHistory GetTestimonialByCustomerId(int customerId)
        {
            return context.TestimonialHistories.Where(l => l.CustomerUserID == customerId).SingleOrDefault();
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