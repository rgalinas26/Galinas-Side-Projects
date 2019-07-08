using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoWebsite.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }
        public bool IsBird { get; set; }
        public bool IsCVNP { get; set; }
        public bool IsFlower { get; set; }
    }
}
