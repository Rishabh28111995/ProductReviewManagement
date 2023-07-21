using System.ComponentModel;

namespace LambdaLinq_Demo;
class Program
{
    static void Main(string[] args)
    {
        List<ProductReview> list = new List<ProductReview>()
        {
            new ProductReview()
            {
                ProductId = 1,
                UserId = 1,
                Rating = 4,
                Review = "Average",
                IsLike = true

            },
            new ProductReview()
            {
                ProductId = 2,
                UserId = 2,
                Rating = 4,
                Review = "Good",
                IsLike = true

            },
            new ProductReview()
            {
                ProductId = 3,
                UserId = 3,
                Rating = 5,
                Review = "Good",
                IsLike = false

            },
            new ProductReview()
            {
                ProductId = 4,
                UserId = 4,
                Rating = 3,
                Review = "Average",
                IsLike = true

            },

            new ProductReview()
            {
                ProductId = 5,
                UserId = 5,
                Rating = 2,
                Review = "Bad",
                IsLike = false

            },
            new ProductReview()
            {
                ProductId = 6,
                UserId = 6,
                Rating = 2,
                Review = "Bad",
                IsLike = false

            },
            new ProductReview()
            {
                ProductId = 7,
                UserId = 7,
                Rating = 2,
                Review = "Bad",
                IsLike = false

            },
            new ProductReview()
            {
                ProductId = 8,
                UserId = 8,
                Rating = 1,
                Review = "Bad",
                IsLike = false

            },
            new ProductReview()
            {
                ProductId = 9,
                UserId = 9,
                Rating = 5,
                Review = "Good",
                IsLike = true

            },
            new ProductReview()
            {
                ProductId = 10,
                UserId = 10,
                Rating = 2,
                Review = "Bad",
                IsLike = false

            },
            new ProductReview()
            {
                ProductId = 11,
                UserId = 11,
                Rating = 5,
                Review = "Good",
                IsLike = false

            },
            new ProductReview()
            {
                ProductId = 12,
                UserId = 12,
                Rating = 5,
                Review = "Good",
                IsLike = true

            },
             new ProductReview()
            {
                ProductId = 13,
                UserId = 13,
                Rating = 5,
                Review = "Good",
                IsLike = true

            },
              new ProductReview()
            {
                ProductId = 14,
                UserId = 14,
                Rating = 1,
                Review = "Bad",
                IsLike = false

            },
               new ProductReview()
            {
                ProductId = 15,
                UserId = 15,
                Rating = 5,
                Review = "Good",
                IsLike = true

            },
                new ProductReview()
            {
                ProductId = 16,
                UserId = 16,
                Rating = 5,
                Review = "Good",
                IsLike = true

            },
                 new ProductReview()
            {
                ProductId = 17,
                UserId = 17,
                Rating = 5,
                Review = "Good",
                IsLike = true

            },
                  new ProductReview()
            {
                ProductId = 12,
                UserId = 12,
                Rating = 5,
                Review = "Good",
                IsLike = true

            },
                   new ProductReview()
                   {
                ProductId = 17,
                UserId = 17,
                Rating = 5,
                Review = "Good",
                IsLike = true

            },
                    new ProductReview()
            {
                ProductId = 20,
                UserId = 20,
                Rating = 5,
                Review = "Good",
                IsLike = true

            },
                    new ProductReview()
            {
                ProductId = 21,
                UserId = 21,
                Rating = 1,
                Review = "Bad",
                IsLike = false

            },
                    new ProductReview()
            {
                ProductId = 22,
                UserId = 22,
                Rating = 3,
                Review = "Average",
                IsLike = true

            },


        };
        while (true)
        {
            Management management = new Management();
            Console.WriteLine("1-Top three Records");
            Console.WriteLine("Choose the Options");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    management.TopRecord(list);
                    break;

                case 2:
                default:
                    break;

                    
            }
        }
    }
}

