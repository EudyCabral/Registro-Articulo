

using Registro_Articulo.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Registro_Articulo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> articulos { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}

