using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RightO.Models;

namespace RightO.DAL
{
    public interface IWorkLocationsRepository : IDisposable
    {
        IEnumerable<WorkLocationsMaster> GetWorkLocations();

        void Save();
    }
}
