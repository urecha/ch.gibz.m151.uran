using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ch.gibz.m151.uran.api.Models.dto
{
    /// <summary>
    /// DTO of a comment as is used in the client application.
    /// </summary>
    public class CommentDto
    {
        /// <summary>
        /// Comment entity id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Usersummary of the exhibitor
        /// </summary>
        //public UserSummary User { get; set; }

        /// <summary>
        /// Referred exhibit
        /// </summary>
        public int ExhibitId { get; set; }
        /// <summary>
        /// Title of the comment
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Content of the comment
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Amount of likes for this comment
        /// </summary>
        public int Likes { get; set; }

    }
}
