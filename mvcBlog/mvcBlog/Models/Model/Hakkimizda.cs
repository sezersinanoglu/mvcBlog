using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvcBlog.Models.Model
{
    [Table("Hakkimizda")]
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Hakkımızda Açıklama")]
        public string Aciklama { get; set; }
    }
}