using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
   public interface IReviewRepoisitory
    {
        public bool InsertReview(Review Rev);
        public bool UpdateReview(Review Rev);
    }
}
