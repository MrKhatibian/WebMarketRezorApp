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

        [Required(ErrorMessage = "عنوان محصول را وارد نمایید")]
        [Display(Name = "عنوان محصول")]
        public string Title { get; set; }

        [Required(ErrorMessage = "تصویر محصول را وارد نمایید")]
        [Display(Name = "تصویر محصول")]
        public string Picture { get; set; }

        [Required(ErrorMessage = "متن جایگزین تصویر محصول را وارد نمایید")]
        [Display(Name = "متن جایگزین تصویر محصول")]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = "عنوان تصویر محصول را وارد نمایید")]
        [Display(Name = "عنوان تصویر محصول")]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = "متن کوتاه محصول را وارد نمایید")]
        [Display(Name = "متن کوتاه محصول")]
        public string ShortDiscription { get; set; }

        [Required(ErrorMessage = "متن اصلی محصول را وارد نمایید")]
        [Display(Name = "متن اصلی محصول")]
        public string Body { get; set; }
        public DateTime CreatDate { get; set; } = DateTime.Now;

    }
}
