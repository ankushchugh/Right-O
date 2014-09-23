using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RightO.Models;

namespace RightO.DAL
{
    interface ISubCategoryRepository :IDisposable
    {
        IEnumerable<SubCategoryMaster> GetSubCategoriesByCategoryID(int categoryId);

        void Save();
    }
}
