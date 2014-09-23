using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using RightO.Models;

namespace RightO.DAL
{
    public class ProRepository : IProRepository, IDisposable
    {
        private RightOEntities context;

        public ProRepository(RightOEntities context)
        {
            this.context = context;
        }

        public IEnumerable<Models.ProUserMaster> GetAllPros()
        {
            return context.ProUserMasters.ToList();
        }

        public Models.ProUserMaster GetPro(int proCustomerId)
        {
            return context.ProUserMasters.Where(l => l.ProUserIdD == proCustomerId).SingleOrDefault();
        }

        public void EditPro(Models.ProUserMaster pro)
        {
            context.Entry(pro).State = EntityState.Modified;
        }

        public void AddPro(Models.ProUserMaster pro)
        {
            context.ProUserMasters.Add(pro);
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