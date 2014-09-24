using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RightO.Models;

namespace RightO.DAL
{
    public interface ISubCategoryRepository :IDisposable
    {
        IEnumerable<SubCategoryMaster> GetSubCategoriesByCategoryID(int categoryId);

        IEnumerable<SubCategoryMaster> GetAllSubCategories();

        void Save();
    }
}
