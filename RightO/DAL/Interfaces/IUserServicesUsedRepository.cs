using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RightO.Models;

namespace RightO.DAL
{
    interface IUserServicesUsedRepository : IDisposable
    {
        IEnumerable<UserServicesUsedHistory> GetAllServicesUsed();

        UserServicesUsedHistory GetUserServiceUsedById(int serviceUsedId);

        void Save();
    }
}
