﻿namespace SupermarketWEB.Models
{
    public class Detail
    {
        public int Id { get; set; }
        public int InvoicedId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public ICollection<Invoice>? Invoices { get; set; } = default!;
    }
}
