using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewUsingLinq
{
    class ProductReview
    {
        public int ProductId
        {
            set;
            get;
        }
        public int UserId
        {
            set;
            get;
        }
        public int Rating
        {
            set;
            get;
        }
        public string Review
        {
            set;
            get;
        }
        public bool isLike
        {
            set;
            get;
        }

    }
}
