using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RightO.Models;

namespace RightO.DAL
{
    interface ICategoryRepository : IDisposable
    {
        IEnumerable<CategoryMaster> GetCategories();
        CategoryMaster GetCategoryByID(int categoryId);
        void Save();    
    }
}
