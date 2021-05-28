using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ch.gibz.m151.uran.api.Models.dto
{
    /// <summary>
    /// DTO for an exhibit without its comments
    /// </summary>
    public class ExhibitDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] File { get; set; }
        public DateTime UploadDate { get; set; }

        //likes too. with username / id in order to display liked/not liked in client

    }
}
