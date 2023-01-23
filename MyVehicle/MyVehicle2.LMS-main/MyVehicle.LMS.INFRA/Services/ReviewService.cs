using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
   public class ReviewService: IReviewServiice
    {
        private readonly IReviewRepoisitory reviewRepoisitory;
        public ReviewService(IReviewRepoisitory reviewRepoisitory)
        {
            this.reviewRepoisitory = reviewRepoisitory;
        }
        public bool InsertReview(Review Rev)
        {
            return reviewRepoisitory.InsertReview(Rev);
        }

        public bool UpdateReview(Review Rev)
        {
            return reviewRepoisitory.UpdateReview(Rev);
        }
    }
}
