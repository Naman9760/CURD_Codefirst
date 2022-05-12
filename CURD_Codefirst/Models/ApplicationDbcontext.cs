using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CURD_Codefirst.Models
{
    public class ApplicationDbcontext :DbContext
    {
        public ApplicationDbcontext() : base("Data Source=CHETUIWK1144\\" +
            "SQLSERVER;Initial Catalog=DBP;Integrated Security=True;Pooling=False") { }
     public DbSet<Catagrie> catagries { get; set; }
      public  DbSet<Product> Products { get; set; }
    }
}