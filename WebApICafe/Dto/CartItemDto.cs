﻿namespace WebApICafe.Dto
{
    public class CartItemDto
    {
        public int ProductId { get; set; }

        public int CartId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
    }
}
