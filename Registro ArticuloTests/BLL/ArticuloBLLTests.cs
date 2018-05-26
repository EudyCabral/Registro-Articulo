using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registro_Articulo.BLL;
using Registro_Articulo.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Registro_Articulo.BLL.Tests
{
    [TestClass()]
    public class ArticuloBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();

            articulo.ArticuloId = 0;
            articulo.FechaVencimiento = "15/7/2016";
            articulo.Descripcion = "Esto fue excelente";
            articulo.Precio = 159 ;
            articulo.Existencia = 9 ;
            articulo.CantidadCotizada = 4;

            paso = ArticuloBLL.Guardar(articulo);


            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();

            articulo.ArticuloId = 0;
            articulo.FechaVencimiento = "15/7/2016";
            articulo.Descripcion = "Esto fue excelente";
            articulo.Precio = 159;
            articulo.Existencia = 9;
            articulo.CantidadCotizada = 4;

            paso = ArticuloBLL.Guardar(articulo);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EditarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();

            articulo.ArticuloId = 0;
            articulo.FechaVencimiento = "15/7/2016";
            articulo.Descripcion = "Esto fue excelente";
            articulo.Precio = 159;
            articulo.Existencia = 9;
            articulo.CantidadCotizada = 4;

            paso = ArticuloBLL.Guardar(articulo);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();

            articulo.ArticuloId = 0;
            articulo.FechaVencimiento = "15/7/2016";
            articulo.Descripcion = "Esto fue excelente";
            articulo.Precio = 159;
            articulo.Existencia = 9;
            articulo.CantidadCotizada = 4;

            paso = ArticuloBLL.Guardar(articulo);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            Articulos articulo = new Articulos();

            articulo.ArticuloId = 0;
            articulo.FechaVencimiento = "15/7/2016";
            articulo.Descripcion = "Esto fue excelente";
            articulo.Precio = 159;
            articulo.Existencia = 9;
            articulo.CantidadCotizada = 4;

            paso = ArticuloBLL.Guardar(articulo);


            Assert.AreEqual(paso, true);
        }
    }
}