using ch.gibz.m151.uran.data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ch.gibz.m151.uran.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        PhotoGalleryContext dbContext = new PhotoGalleryContext();

        [HttpGet("exhibit/{id}")]
        public IActionResult GetForExhibit(int id)
        {
            List<Comment> comments = new List<Comment>(dbContext.Comments.Where(c => c.ExhibitId == id).ToArray());
            return Ok(comments);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Comment comment = dbContext.Comments.Find(id);
            if (comment == null)
            {
                throw new ArgumentException($"Can't find comment with id {id}");
            }
            return Ok(comment);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Comment comment)
        {
            dbContext.Comments.Add(comment);
            dbContext.SaveChanges();
            return CreatedAtAction(nameof(Create), comment);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Comment comment)
        {
            Comment commentToModify = dbContext.Comments.Find(id);
            commentToModify.Title = comment.Title;
            commentToModify.Content = comment.Content;
            //change date or bool would be nice
            dbContext.Entry(commentToModify).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return Ok(comment);
        }

        [HttpGet("like/{id}")]
        public IActionResult LikeComment(int id)
        {
            CommentLike like = dbContext.CommentLikes.Single(l => l.CommentId == id);
            //TODO needs user verification quoi
            if (like != null)
            {
                dbContext.CommentLikes.Remove(like);
                return Ok("Exhibit unliked");
            }
            dbContext.CommentLikes.Add(new CommentLike { CommentId = id, UserId = 1 });
            dbContext.SaveChanges();
            return Ok("Exhibit liked");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            dbContext.Comments.Remove(dbContext.Comments.Find(id));
            return Ok("Deleted comment");
        }
    }
}
