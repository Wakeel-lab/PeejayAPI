using System;
using System.Collections.Generic;

#nullable disable

namespace PeejayAPI.Models.Models
{
    public partial class ProductImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
