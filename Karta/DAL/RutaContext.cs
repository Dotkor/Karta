using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Karta.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Karta.DAL
{
    public class RutaContext : DbContext
    {
        public RutaContext() : base("RutaContext") { }
        public DbSet<Ruta> Ruta { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}