using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CURD_Codefirst.Models
{
    public class Product
    {
        
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Descri { get; set; }
        public int Contity { get; set; }
        public int Price { get; set; }
        public Catagrie catagrie { get; set; }
    }
}