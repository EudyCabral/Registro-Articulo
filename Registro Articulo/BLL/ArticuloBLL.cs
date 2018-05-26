﻿using Registro_de_Cotizacion_Articulo.DAL;
using Registro_de_Cotizacion_Articulo.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Registro_de_Cotizacion_Articulo.BLL
{
    public class ArticuloBLL
    {
        public static bool Guardar(Articulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.articulos.Add(articulo) != null)
                {
                    contexto.SaveChanges();
                    paso = true;

                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }



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



        public static bool Editar(Articulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            { throw; }
            return paso;
        }

        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos articulo = new Articulos();

            try
            {
                articulo = contexto.articulos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;

        }

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