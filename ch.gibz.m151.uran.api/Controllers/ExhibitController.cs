using ch.gibz.m151.uran.data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ch.gibz.m151.uran.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExhibitController : Controller
    {
        PhotoGalleryContext dbContext = new PhotoGalleryContext();

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            List<Exhibit> exhibits = new List<Exhibit>((dbContext.Exhibits).ToArray());
            return Ok(exhibits);
        }

        //[HttpGet("user/{id}")]
        //public IActionResult GetForUser(int id)
        //{
        //    //only give the authenticated user's exhibits
        //    List<Exhibit> exhibits = new List<Exhibit>((dbContext.Exhibits.Where(e => e.UserId == id)).toArray());
        //
        //    return Ok(exhibits);
        //}

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Exhibit exhibit = dbContext.Exhibits.Find(id);
            if (exhibit == null)
            {
                throw new ArgumentException($"Can't find comment with id {id}");
            }
            return Ok(exhibit);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Exhibit exhibit)
        {
            dbContext.Exhibits.Add(exhibit);
            dbContext.SaveChanges();
            return CreatedAtAction(nameof(Create), exhibit);
        }

        [HttpGet("like/{id}")]
        public IActionResult LikeExhibit(int id)
        {
            ExhibitLike like = dbContext.ExhibitLikes.Single(l => l.ExhibitId == id);
            //TODO needs user verification quoi
            if (like != null)
            {
                dbContext.ExhibitLikes.Remove(like);
                return Ok("Exhibit unliked");
            }
            dbContext.ExhibitLikes.Add(new ExhibitLike { ExhibitId = id, UserId = 1 });
            dbContext.SaveChanges();
            return Ok("Exhibit liked");
        }

        [HttpPost]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            dbContext.Comments.Remove(dbContext.Comments.Find(id));
            return Ok("Deleted exhibit");
        }
    }
}
