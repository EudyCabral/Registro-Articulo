using Registro_de_Cotizacion_Articulo.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Registro_de_Cotizacion_Articulo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> articulos { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}

