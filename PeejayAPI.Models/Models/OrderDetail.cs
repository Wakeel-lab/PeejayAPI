using System;
using System.Collections.Generic;

#nullable disable

namespace PeejayAPI.Models.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public decimal? Total { get; set; }
        public int? PaymentId { get; set; }
        public string Status { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        public virtual PaymentDetail Payment { get; set; }
    }
}
