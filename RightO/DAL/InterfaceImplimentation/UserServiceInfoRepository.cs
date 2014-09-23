using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RightO.Models;

namespace RightO.DAL
{
    public class UserServiceInfoRepository : IUserServicesInfoRepository, IDisposable
    {
        private RightOEntities context;

        public UserServiceInfoRepository(RightOEntities context)
        {
            this.context = context;
        }
        public void AddUserService(Models.UserServiceInfo userServiceInfo)
        {
            context.UserServiceInfoes.Add(userServiceInfo);
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