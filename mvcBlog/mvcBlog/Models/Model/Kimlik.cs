﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvcBlog.Models.Model
{
    [Table("Kimlik")]
    public class Kimlik
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Site Başlık")]
        public string Title { get; set; }
        [DisplayName("Anahtar Kelimeler")]
        [Required,StringLength(200,ErrorMessage ="200 Karakter Olmalıdır")]
        public string Keywords { get; set; }
        [DisplayName("Site Açıklama")]
        [Required, StringLength(300, ErrorMessage = "300 Karakter Olmalıdır")]
        public string Description { get; set; }
        [DisplayName("Site Logo")]
        public string LogURL { get; set; }
        [DisplayName("Site Unvan")]
        public string Unvan { get; set; }
    }
}