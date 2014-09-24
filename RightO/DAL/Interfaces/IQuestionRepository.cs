using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RightO.Models;

namespace RightO.DAL
{
    public interface IQuestionRepository : IDisposable
    {
        IEnumerable<QuestionMaster> GetAllQuestionsBySubcategory(int subcategoryId);

        void Save();
    }
}
