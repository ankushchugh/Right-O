using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RightO.Models;

namespace RightO.DAL
{
    public interface IFeedbackRepository : IDisposable
    {
        void AddFeedback(FeedBackHistory feedback);

        FeedBackHistory GetFeedbackByCustomerId(int customerId);

        void Save();
    }
}
