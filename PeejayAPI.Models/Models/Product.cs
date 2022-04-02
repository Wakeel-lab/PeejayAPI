using System;
using System.Collections.Generic;

#nullable disable

namespace PeejayAPI.Models.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            OrderItems = new HashSet<OrderItem>();
            ProductImages = new HashSet<ProductImage>();
            ProductRatings = new HashSet<ProductRating>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Category { get; set; }
        public decimal? Price { get; set; }
        public string Sku { get; set; }
        public int? Quantity { get; set; }
        public bool? Available { get; set; }
        public int? DiscountId { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        public virtual Category CategoryNavigation { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductRating> ProductRatings { get; set; }
    }
}
