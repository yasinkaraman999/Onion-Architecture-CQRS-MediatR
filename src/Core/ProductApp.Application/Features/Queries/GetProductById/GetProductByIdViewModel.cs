﻿using System;
namespace ProductApp.Application.Features.Queries.GetProductById
{
	public class GetProductByIdViewModel
	{
		public Guid Id { get; set; }

		public DateTime CreateDate { get; set; }
		public string Name { get; set; }

		public int Quantity { get; set; }
		 
		public decimal Value { get; set; }
	}
}

