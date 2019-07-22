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
        //REMEMBER TO DEAL WITH THE NO CACHE ISSUE. REFERENCE RYVER MESSAGE WITH MIKE
        private IPhotoDAO photoDAO;
        public HomeController(IPhotoDAO photoDAO)
        {
            this.photoDAO = photoDAO;
        }
        [ResponseCache (NoStore = true, Location = ResponseCacheLocation.None)]
        public IActionResult Index()
        {


            PhotoVM photoVM = new PhotoVM();
            photoVM.DetailPagePhotoList = photoDAO.GetAllPhotos();
            photoVM.BirdBoolCount = GetBirdCountFromSession();
            photoVM.CVNPBoolCount = GetCVNPCountFromSession();
            photoVM.PlantBoolCount = GetPlantCountFromSession();
            return View(photoVM);
            //IList<Photo> photos = photoDAO.GetAllPhotos();
            //return View(photos);
        }
        public IActionResult Details(int id)
        {
            Photo photo = photoDAO.GetPhotoById(id);
            if(photo.IsBird == true)
            {
                SetBirdCountInSession();
            }
            else if(photo.IsCVNP == true)
            {
                SetCVNPCountInSession();
            }
            else if(photo.IsPlant == true)
            {
                SetPlantCountInSession();
            }
            return View(photo);

        }


        #region Get/Set Session helper methods
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
        private void SetBirdCountInSession()
        {
            int? birdSessionCount = GetBirdCountFromSession();
            birdSessionCount++;
            HttpContext.Session.SetInt32("BirdCount", (int)birdSessionCount);
        }
        private void SetCVNPCountInSession()
        {
            int? CVNPSessionCount = GetCVNPCountFromSession();
            CVNPSessionCount++;
            HttpContext.Session.SetInt32("CVNPCount", (int)CVNPSessionCount);
        }
        private void SetPlantCountInSession()
        {
            int? plantSessionCount = GetPlantCountFromSession();
            plantSessionCount++;
            HttpContext.Session.SetInt32("PlantCount", (int)plantSessionCount);
        }
        #endregion
        #region Default IActions from ASP.NET Framework (Privacy, Error)
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}
