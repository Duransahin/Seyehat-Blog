using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SeyahatSitesi.Models.Sınıflar
{
    public class Blogyorum
    {
        public IEnumerable<Blog> Değer1 { get; set; }
        public IEnumerable<Yorumlar>Değer2{get;set;}
        public IEnumerable<Blog> Değer3 { get; set; }

    }
}