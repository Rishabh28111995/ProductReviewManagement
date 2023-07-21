using System;
namespace LambdaLinq_Demo
{
	//Lambda expression is used to create anonymous function, expression and
	//body memeber.
	//It's a short block of code that accepts parameter and return a value
	//Use => is a lambda operatorwhich is used for all the lambda expressions.
	public class ProductReview
	{
		public int ProductId { get; set; }
		public int UserId { get; set; }
		public int Rating { get; set; }
		public string Review { get; set; }
		public bool IsLike { get; set; }
		
	}

}