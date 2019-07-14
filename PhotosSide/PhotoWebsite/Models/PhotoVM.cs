using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoWebsite.Models
{
    public class PhotoVM
    {
        public int? BirdBoolCount { get; set; }
        public int? CVNPBoolCount { get; set; }
        public int? PlantBoolCount { get; set; }
        public IList<Photo> DetailPagePhotoList { get; set; }
    }
}
