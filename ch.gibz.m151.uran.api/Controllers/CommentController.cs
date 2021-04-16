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
        
        [HttpGet("comments")]
        public IActionResult GetComments(int exhibitId)
        {
            List<Comment> comments = new List<Comment>(dbContext.Comments.Where(c => c.ExhibitId == exhibitId).ToArray());
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
        public IActionResult Post([FromBody] Comment comment)
        {
            dbContext.Comments.Add(comment);
            dbContext.SaveChanges();
            return Ok("Created comment");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Comment comment)
        {
            Comment commentToModify = dbContext.Comments.Find(id);
            commentToModify.Title = comment.Title;
            commentToModify.Content = comment.Content;
            //change date or bool would be nice
            dbContext.Entry(commentToModify).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return Ok("Updated comment");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            dbContext.Comments.Remove(dbContext.Comments.Find(id));
            return Ok("Deleted comment");
        }
    }
}
