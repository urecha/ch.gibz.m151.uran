using System;
using System.Collections.Generic;

#nullable disable

namespace ch.gibz.m151.uran.data.Models
{
    public partial class Exhibit
    {
        public Exhibit()
        {
            Comments = new HashSet<Comment>();
            ExhibitLikes = new HashSet<ExhibitLike>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] File { get; set; }
        public DateTime UploadDate { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<ExhibitLike> ExhibitLikes { get; set; }
    }
}
