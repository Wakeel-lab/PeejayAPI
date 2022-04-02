using System;
using System.Collections.Generic;

#nullable disable

namespace PeejayAPI.Models.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int? SessionId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual ShoppingSession Session { get; set; }
    }
}
