using System;
using System.Collections.Generic;

#nullable disable

namespace PeejayAPI.Models.Models
{
    public partial class ProductRating
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Rating { get; set; }
        public string Ip { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
