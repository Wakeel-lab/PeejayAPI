using System;
using System.Collections.Generic;

#nullable disable

namespace PeejayAPI.Models.Models
{
    public partial class ShoppingSession
    {
        public ShoppingSession()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public decimal? Total { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
