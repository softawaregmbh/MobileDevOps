using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ThumbnailUrl { get; set; }

        public string Url { get; set; }
    }
}
