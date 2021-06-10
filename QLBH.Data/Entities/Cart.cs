using System;
using System.Collections.Generic;
using System.Text;

namespace QLBH.Data.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public Decimal Price { get; set; }
        public Guid UserId { get; set; }
        public Product Product { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
