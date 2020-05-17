using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvcBlog.Models.Model
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        [Required,StringLength(50,ErrorMessage ="50 Karakter Olmalıdır")]
        public string Eposta { get; set; }
       [Required,StringLength(50,ErrorMessage ="50 Karakter Olmalıdır")]
        public string Sifre { get; set; }
        public string Yetki { get; set; }
    }
}