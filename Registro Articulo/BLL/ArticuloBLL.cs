

using Registro_Articulo.DAL;
using Registro_Articulo.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Registro_Articulo.BLL
{
    // En esta clase debemos programar todas la logica de negocios
    public class ArticuloBLL
    {
        
        //Permite guardar una entidad en la base de datos
        public static bool Guardar(Articulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto(); // se hace una instancia de la clase contexto

            try
            {
                if (contexto.articulos.Add(articulo) != null)
                {
                    contexto.SaveChanges(); // guarda los cambios
                    paso = true;

                }
                contexto.Dispose(); //se cierra la conexion de la base de datos
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        //Permite Elimiar una entidad en la base de datos
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Articulos articulo = contexto.articulos.Find(id);
                if (articulo != null)
                {
                    contexto.Entry(articulo).State = EntityState.Deleted;
                }
                if (contexto.SaveChanges() > 0)
                {
                    contexto.Dispose();
                    paso = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        //Permite Editar una entidad en la base de datos
        public static bool Editar(Articulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto(); // se hace una instancia para la conexion

            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0) // Guarda los cambios despues de ser editados 
                {
                    paso = true;
                }
                contexto.Dispose(); // se cierra la conexion
            }
            catch (Exception)
            { throw; }
            return paso;
        }

        //Permite Buscar una entidad en la base de datos
        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();// se utiliza para hacer una conexion
            Articulos articulo = new Articulos(); // se hace una instancia para buscar los atributos de una entidad en la base de datos

            try
            {
                articulo = contexto.articulos.Find(id);//Se busca
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;

        }
        //Permite Listar todas o una entidad de la base de datos
        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            List<Articulos> articulos = new List<Articulos>();
            Contexto contexto = new Contexto();

            try
            {
                articulos = contexto.articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulos;
        }
    }
}
