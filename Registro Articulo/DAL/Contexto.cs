

using Registro_Articulo.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Registro_Articulo.DAL
{
    //Aqui agregamos public tambien, para que la clase pueda ser encontrada en cualquier parte del proyecto,
    // heredamos de DbContext para que EntityFramework pueda hacer su magia
    public class Contexto : DbContext
    {
        public DbSet<Articulos> articulos { get; set; }

        //base("ConStra") para pasar la conexcion a la clase base de EntityFramework
        public Contexto() : base("ConStr")
        { }
    }
}

