﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyahatSitesi.Models.Sınıflar
{
    public class AdresBlog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string AdresAcık { get; set; }
        public string Mail { get; set; }
        public string Konum { get; set; }

    }
}