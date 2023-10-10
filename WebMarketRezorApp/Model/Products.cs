using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarketRezorApp.Model
{
    public class Products
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string ShortDiscription { get; set; }
        public string Body { get; set; }
        public DateTime CreatDate { get; set; } = DateTime.Now;

    }
}
