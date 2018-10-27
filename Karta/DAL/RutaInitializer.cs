using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Karta.Models;

namespace Karta.DAL
{
    public class RutaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RutaContext>
    {
        protected override void Seed(RutaContext context)
        {
            var Rutas = new List<Ruta>
            {
            new Ruta{ime="Ruta1",Ax=18.699013,Ay=45.554711,Bx=18.695860,By=45.554836},
            new Ruta{ime="Ruta2",Ax=18.694991,Ay=45.553980,Bx=18.695946,By=45.555933},
            new Ruta{ime="Ruta3",Ax=18.694079,Ay=45.555084,Bx=18.696740,By=45.554784}

            };

            Rutas.ForEach(s => context.Ruta.Add(s));
            context.SaveChanges();
        }
    }
}
