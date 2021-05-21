using ch.gibz.m151.uran.business;
using ch.gibz.m151.uran.data.Models;
using ch.gibz.m151.uran.net_client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ch.gibz.m151.uran.net_client.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Comments()
        {
            List<SimpleComment> comments = new List<SimpleComment>
                (new CommentRepository().getAll());
            return View(comments);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new SimpleComment());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SimpleComment comment)
        {
            new CommentRepository().saveComment(comment);
            return RedirectToAction(nameof(Index));
        }
    }
}
