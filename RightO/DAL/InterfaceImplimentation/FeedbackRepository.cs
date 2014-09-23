using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RightO.Models;

namespace RightO.DAL
{
    public class FeedbackRepository : IFeedbackRepository, IDisposable
    {
        private RightOEntities context;

        public FeedbackRepository(RightOEntities context)
        {
            this.context = context;
        }
        public void AddFeedback(Models.FeedBackHistory feedback)
        {
            context.FeedBackHistories.Add(feedback);
        }

        public Models.FeedBackHistory GetFeedbackByCustomerId(int customerId)
        {
            return context.FeedBackHistories.Where(l => l.CustomerUserID == customerId).SingleOrDefault();
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