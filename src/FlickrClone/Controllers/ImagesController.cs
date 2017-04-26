using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FlickrClone.Models;

namespace FlickrClone.Controllers
{
    public class ImagesController : Controller
    {
        private FlickrCloneContext db = new FlickrCloneContext();
        public IActionResult Index()
        {
            return View(db.Images.ToList());
        }
    }
}
