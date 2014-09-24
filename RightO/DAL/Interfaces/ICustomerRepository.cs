using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RightO.Models;

namespace RightO.DAL
{
    public interface ICustomerRepository:IDisposable
    {
        IEnumerable<CustomerUserMaster> GetAllCustomers();

        CustomerUserMaster GetCustomer(int customerId);

        void AddNewCustomer(CustomerUserMaster customer);

        void EditExistingCustomer(CustomerUserMaster customer);

        void Save();
    }
}
