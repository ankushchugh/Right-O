using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RightO.Models;

namespace RightO.DAL
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        private RightOEntities context;

        public CustomerRepository(RightOEntities context)
        {
            this.context = context;
        }

        public IEnumerable<Models.CustomerUserMaster> GetAllCustomers()
        {
            return context.CustomerUserMasters.ToList();
        }

        public Models.CustomerUserMaster GetCustomer(int customerId)
        {
            return context.CustomerUserMasters.Find(customerId);
        }

        public void AddNewCustomer(Models.CustomerUserMaster customer)
        {
            context.CustomerUserMasters.Add(customer);
        }

        public void EditExistingCustomer(Models.CustomerUserMaster customer)
        {
            context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
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