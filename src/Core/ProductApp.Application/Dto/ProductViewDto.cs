using System;
namespace ProductApp.Application.Dto
{
	public class ProductViewDto
	{
		public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}

