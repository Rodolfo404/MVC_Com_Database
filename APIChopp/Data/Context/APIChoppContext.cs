using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class APIChoppContext : DbContext
    {

        public DbSet<Chopp> Chopps { get; set; }

        public APIChoppContext() : base("Data Source=192.168.0.156;Initial Catalog=Produto;Persist Security Info=True;User ID=Rodolfo;Password=123321@")
        {

        }
    }

}
