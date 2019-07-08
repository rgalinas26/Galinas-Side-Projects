using PhotoWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoWebsite.DAL
{
    public interface IPhotoDAO
    {
        IList<Photo> GetAllPhotos();
        Photo GetPhotoById(int id);
    }
}
