using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RightO.Models;

namespace RightO.DAL
{
    public class UserServicesUsedRepository : IUserServicesUsedRepository, IDisposable
    {
        private RightOEntities context;

        public UserServicesUsedRepository(RightOEntities context)
        {
            this.context = context;
        }
        public IEnumerable<Models.UserServicesUsedHistory> GetAllServicesUsed()
        {
            return context.UserServicesUsedHistories.ToList();
        }

        public Models.UserServicesUsedHistory GetUserServiceUsedById(int serviceUsedId)
        {
            return context.UserServicesUsedHistories.Where(l => l.UserServicesUsedHistoryID == serviceUsedId).SingleOrDefault();
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