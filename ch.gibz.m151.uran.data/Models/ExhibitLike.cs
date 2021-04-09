using System;
using System.Collections.Generic;

#nullable disable

namespace ch.gibz.m151.uran.data.Models
{
    public partial class ExhibitLike
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ExhibitId { get; set; }

        public virtual Exhibit Exhibit { get; set; }
        public virtual User User { get; set; }
    }
}
