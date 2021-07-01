using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ReviewUsingLinq
{
    class Management
    {
        public readonly DataTable dataTable = new DataTable();
        //UC2
        public void TopRecords(List<ProductReview> review)
        {
            var recordedData = (from productReview in review orderby productReview.Rating descending select productReview).Take(3);
            foreach( var list in recordedData)
            {
                Console.WriteLine("ProductId:-"+list.ProductId+" "+"UserId:-"+list.UserId+" "+"Rating:-"+list.Rating+" "+"Review:-"+list.Review+" "+"IsLike:-"+list.isLike);
            }

        }
        //UC3
        public void SelectRecords(List<ProductReview> reviewlist)
        {
            var recordedData = from ProductReview in reviewlist
                               where (ProductReview.ProductId == 1 || ProductReview.ProductId == 4 || ProductReview.ProductId == 9)
                               && (ProductReview.Rating > 3)
                               select ProductReview;

            foreach(var list in recordedData)
            {
                Console.WriteLine("productid:-" + list.ProductId + " " + "userid:-" + list.UserId + "rating:-" + list.Rating + " " + "review:-" + list.Review + " " + "islike:-" + list.isLike);
            }
        }
    }
}
