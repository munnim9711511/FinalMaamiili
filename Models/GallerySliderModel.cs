using System;
using System.ComponentModel.DataAnnotations;

namespace coouncil.Models
{
    public class GallerySliderModel
    {
        [Key]
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public string Text { get; set; }
    }
}