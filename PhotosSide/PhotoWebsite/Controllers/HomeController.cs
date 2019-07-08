using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhotoWebsite.DAL;
using PhotoWebsite.Models;

namespace PhotoWebsite.Controllers
{
    public class HomeController : Controller
    {
        private IPhotoDAO photoDAO;
        public HomeController(IPhotoDAO photoDAO)
        {
            this.photoDAO = photoDAO;
        }
        public IActionResult Index()
        {
            IList<Photo> photos = photoDAO.GetAllPhotos();
            return View(photos);
        }
        public IActionResult Details(int id)
        {
            Photo photo = photoDAO.GetPhotoById(id);
            return View(photo);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
