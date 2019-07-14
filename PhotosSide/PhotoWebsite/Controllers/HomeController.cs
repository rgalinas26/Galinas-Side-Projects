using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            PhotoVM photoVM = new PhotoVM();
            photoVM.DetailPagePhotoList = photoDAO.GetAllPhotos();

            return View(photoVM);
            //IList<Photo> photos = photoDAO.GetAllPhotos();
            //return View(photos);
        }
        public IActionResult Details(int id)
        {
            Photo photo = photoDAO.GetPhotoById(id);
            return View(photo);

        }



        private int? GetBirdCountFromSession()
        {
            int? newBirdCount = HttpContext.Session.GetInt32("BirdCount");
            
            if (newBirdCount == null)
            {
                newBirdCount = 0;
                HttpContext.Session.SetInt32("BirdCount", 0);
            }
            return newBirdCount;
        }
        private int? GetCVNPCountFromSession()
        {
            int? newCVNPCount = HttpContext.Session.GetInt32("CVNPCount");

            if (newCVNPCount == null)
            {
                newCVNPCount = 0;
                HttpContext.Session.SetInt32("CVNPCount", 0);
            }
            return newCVNPCount;
        }
        private int? GetPlantCountFromSession()
        {
            int? newPlantCount = HttpContext.Session.GetInt32("PlantCount");

            if (newPlantCount == null)
            {
                newPlantCount = 0;
                HttpContext.Session.SetInt32("PlantCount", 0);
            }
            return newPlantCount;
        }
        private void SetCountsInSession(string unit)
        {
            if (unit == "F")
            {
                HttpContext.Session.SetString("TempUnit", "C");
            }
            else
            {
                HttpContext.Session.SetString("TempUnit", "F");
            }
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
