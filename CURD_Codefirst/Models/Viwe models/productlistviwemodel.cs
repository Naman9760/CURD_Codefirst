using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CURD_Codefirst.Models.Viwe_models
{
    public class productlistviwemodel
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Descri { get; set; }
        public int Contity { get; set; }
        public int Price { get; set; }
        public string catagrie { get; set; }
    }
}