using System;
using System.Collections.Generic;
using System.Text;

namespace EcomReview.Library.Entity.Models
{
    public class ReviewModel
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Star { get; set; }
        public DateTime ReviewTimeStamp { get; set; }
        public DateTime UpdateTimeStamp { get; set; }
        public string ReviewMsg { get; set; }

    }
}
