using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RightO.Models;

namespace RightO.DAL
{
    public class WorkLocationsRepository : IWorkLocationsRepository, IDisposable
    {
        private RightOEntities context;

        public WorkLocationsRepository(RightOEntities context)
        {
            this.context = context;
        }
        public IEnumerable<Models.WorkLocationsMaster> GetWorkLocations()
        {
            return context.WorkLocationsMasters.ToList();
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