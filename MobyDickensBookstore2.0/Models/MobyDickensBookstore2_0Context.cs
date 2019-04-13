using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MobyDickensBookstore2._0.Models
{
    public class MobyDickensBookstore2_0Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MobyDickensBookstore2_0Context() : base("name=MobyDickensBookstore2_0Context")
        {
        }

        public System.Data.Entity.DbSet<MobyDickensBookstore2._0.Models.Book> Books { get; set; }
    }
}
