using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Registro_Articulo.ENTIDADES
{
    // se debe Descargar Install-package EntityFrameWork para utilizar la llave primaria
    public class Articulos
    {
        // Esta es la LLave Primaria
        [Key]// kEY   Se importa de la librefia System.ComponentModel.DataAnnotations;
        public int ArticuloId { get; set; }
        public string FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public int CantidadCotizada { get; set; }

        // Construtor lleno
        public Articulos(int articuloId, string FechaVencimiento, string descripcion, decimal precio, int existencia, int cantidadCotizada)
        {
            ArticuloId = articuloId;
            this.FechaVencimiento = FechaVencimiento;
            this.Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;
            CantidadCotizada = cantidadCotizada;
        }
        // Constructor vacio
        public Articulos()
        {
            ArticuloId = 0;
            FechaVencimiento = string.Empty;
            Descripcion = string.Empty;
            Precio = 0;
            Existencia = 0;
            CantidadCotizada = 0;
        }
    }


}
