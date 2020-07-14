using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }

        [Display(Name ="Ngày p.hành")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Thể loại")]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Giá vé")]
        public decimal Price { get; set; }
    }
}
