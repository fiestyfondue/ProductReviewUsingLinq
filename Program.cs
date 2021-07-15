using System;
using System.Collections.Generic;

namespace ReviewUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review Management system");

            //UC1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {//Adding Custom Class Objects in List
                new ProductReview(){ProductId=1,UserId=1,Rating=5,Review="Average Product",isLike=true },
                new ProductReview(){ProductId=2,UserId=2,Rating=7,Review="Good Product",isLike=true },
                new ProductReview(){ProductId=3,UserId=3,Rating=2,Review="Bad Product",isLike=false },
                new ProductReview(){ProductId=4,UserId=4,Rating=9,Review="Great Product",isLike=true },
                new ProductReview(){ProductId=5,UserId=5,Rating=1,Review="Worst Product",isLike=false },
                new ProductReview(){ProductId=6,UserId=6,Rating=6,Review="OKOk Product",isLike=true },
                new ProductReview(){ProductId=1,UserId=7,Rating=6,Review="Average Product",isLike=true },
                new ProductReview(){ProductId=8,UserId=8,Rating=8,Review="Nice Product",isLike=true },
                new ProductReview(){ProductId=9,UserId=9,Rating=1,Review="Crap Product",isLike=false },
                new ProductReview(){ProductId=10,UserId=10,Rating=10,Review=" Product",isLike=true }
            };
            // using foreach LINQ method for Query Exection
            foreach (var list in productReviewList)
            {
                Console.WriteLine("productid:-" + list.ProductId + " " + "userid:-" + list.UserId + "rating:-" + list.Rating + " " + "review:-" + list.Review + " " + "islike:-" + list.isLike);
            }
            Management M = new Management();
            //M.SelectRecords(productReviewList);//UC3
            //M.RetrieveCountOfRecords(productReviewList);//UC4
            //Console.WriteLine("Retrieving review by Product ID");
            //M.RetrieveProductIDAndReview(productReviewList);
            //Console.WriteLine("Skipping Top 5 records");
            //M.SkipTopFiveRecords(productReviewList);
            //Console.WriteLine("Getting Product ID and Review");
            //M.SelectProductIDAndReviews(productReviewList);
            Console.WriteLine("UC7- Create DataTable .");
            DataTableOP dataTableOperations = new DataTableOP();
            dataTableOperations.CreateDataTable();
            Console.ReadLine();
            
        }
    }
}
