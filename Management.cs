using System;
namespace LambdaLinq_Demo
{
	public class Management
	{
		public void TopRecord(List<ProductReview> products)
		{
			var result = products.OrderByDescending(x => x.Rating).Take(3);
			var record = (from product in products orderby product.Review descending select product);
			Console.WriteLine("using LinQ");
			Console.WriteLine("-----------");
			foreach(var prod in record)
			{
				Console.WriteLine(prod.ProductId + " " + prod.UserId + " " + prod.Rating + " " + prod.Review + " " + prod.IsLike);
			}
			foreach(var prod in result)
			{
				Console.WriteLine(prod.ProductId+" "+ prod.UserId+" "+ prod.Rating+ " "+ prod.Review+" "+ prod.IsLike);
			}
		}
	}
}

