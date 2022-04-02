using System;
using System.Collections.Generic;

#nullable disable

namespace PeejayAPI.Models.Models
{
    public partial class TrackCode
    {
        public int Id { get; set; }
        public string TrackCode1 { get; set; }
        public int? OrderId { get; set; }
        public int? UserId { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
    }
}
