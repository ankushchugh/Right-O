using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RightO.Models;

namespace RightO.DAL
{
    interface IWorkTimingsRepository : IDisposable
    {
        IEnumerable<WorkTimingsMaster> GetWorkTimings();

        void Save();
    }
}
