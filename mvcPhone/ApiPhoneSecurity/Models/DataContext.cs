using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPhoneSecurity.Models
{

    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiPhoneSecurity.Models.Phone> Phones { get; set; }
    }
}