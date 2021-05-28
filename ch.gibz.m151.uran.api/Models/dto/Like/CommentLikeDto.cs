using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ch.gibz.m151.uran.api.Models.dto
{
    /// <summary>
    /// DTO for a comment-like entity
    /// Has intel about which comment was liked by which user
    /// </summary>
    public class CommentLikeDto
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int UserId { get; set; }
    }
}
