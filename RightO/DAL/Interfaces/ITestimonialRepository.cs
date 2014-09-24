using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RightO.Models;

namespace RightO.DAL
{
    public interface ITestimonialRepository : IDisposable
    {
        IEnumerable<TestimonialHistory> GetAllTestimonials();

        TestimonialHistory GetTestimonialByCustomerId(int customerId);

        void Save();

    }
}
