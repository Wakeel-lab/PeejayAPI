using System;
using System.Collections.Generic;

#nullable disable

namespace PeejayAPI.Models.Models
{
    public partial class Discount
    {
        public Discount()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
