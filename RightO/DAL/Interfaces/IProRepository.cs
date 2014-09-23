using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RightO.Models;

namespace RightO.DAL
{
    interface IProRepository :IDisposable
    {
        IEnumerable<ProUserMaster> GetAllPros();

        ProUserMaster GetPro(int proCustomerId);

        void EditPro(ProUserMaster pro);

        void AddPro(ProUserMaster pro);

        void Save();
    }
}
