using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ReviewUsingLinq
{
    class Management
    {
        public readonly DataTableOP dataTable = new DataTableOP();
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
                               //where (ProductReview.ProductId == 1 || ProductReview.ProductId == 4 || ProductReview.ProductId == 9)
                               //&& (ProductReview.Rating > 3)
                               
                               select ProductReview;

            foreach(var list in recordedData)
            {
                Console.WriteLine("productid:-" + list.ProductId + " " + "userid:-" + list.UserId + "rating:-" + list.Rating + " " + "review:-" + list.Review + " " + "islike:-" + list.isLike);
            }
        }
        //UC4
        public void RetrieveCountOfRecords(List<ProductReview> reviewlist)
        {
            var recordedData = reviewlist.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach(var list in recordedData)
            {
                Console.WriteLine(list.ProductId+"----"+list.Count);
            }
        }
        public void RetrieveProductIDAndReview(List<ProductReview> listProductReview)
        {
            
            var recordedData = listProductReview.Select(x => new { ProductID = x.ProductId, Review = x.Review });
            Console.WriteLine("ID with Review");
            foreach (var list in recordedData)
            {
                //Output
                Console.WriteLine("ID:" + list.ProductID + "==>" + list.Review);

            }
        }
        public void SkipTopFiveRecords(List<ProductReview> listProductReview)
        {

            var recordedData = (from productReviews in listProductReview
                                select productReviews).Skip(5);
            Console.WriteLine("Retrieving records after skipping top 5 records- ");
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductId + " " + "UserID:- " + list.UserId
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);

            }
        }
        public void SelectProductIDAndReviews(List<ProductReview> listProductReview)
        {
            // method parameter(s) => method return value.
            var recordedData = listProductReview.Select(x => new { x.ProductId, x.Review });
            foreach (var list in recordedData)
            {
                //Output
                Console.WriteLine("ID:" + list.ProductId + "===>" + list.Review);
            }
        }
    }
}
