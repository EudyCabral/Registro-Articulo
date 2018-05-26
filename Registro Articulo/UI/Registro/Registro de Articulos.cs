using Registro_Articulo.DAL;
using Registro_Articulo.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Registro_Articulo.UI.Registro
{
    public partial class Registro_de_Articulos : Form
    {
        public Registro_de_Articulos()
        {
            InitializeComponent();
        }

        private void Registro_de_Articulos_Load(object sender, EventArgs e)
        {

        }

        private Articulos LLenaClase()
        {
            Articulos articulo = new Articulos();

            articulo.ArticuloId = Convert.ToInt32(ArticuloIDnumericUpDown.Value);
            articulo.FechaVencimiento = FechamaskedTextBox.Text;
            articulo.Descripcion = DescripciontextBox.Text;
            articulo.Precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            articulo.Existencia = Convert.ToInt32(ExistencianumericUpDown.Value);
            articulo.CantidadCotizada = Convert.ToInt32(CantidadCotizadanumericUpDown.Value);
            return articulo;

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticuloIDnumericUpDown.Value);
            Articulos articulo = BLL.ArticuloBLL.Buscar(id);

            if (validar(1))
            {
                MessageBox.Show("Llene Casilla");
            }
            else
            {
                if (articulo != null)
                {
                    ArticuloIDnumericUpDown.Value = articulo.ArticuloId;
                    FechamaskedTextBox.Text = articulo.FechaVencimiento;
                    DescripciontextBox.Text = articulo.Descripcion;
                    PrecionumericUpDown.Value = articulo.Precio;
                    ExistencianumericUpDown.Value = articulo.Existencia;
                    CantidadCotizadanumericUpDown.Value = articulo.CantidadCotizada;
                    errorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("No se Encontro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider.Clear();
                }
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ArticuloIDnumericUpDown.Value = 0;
            FechamaskedTextBox.Clear();
            DescripciontextBox.Clear();
            PrecionumericUpDown.Value = 0;
            ExistencianumericUpDown.Value = 0;
            CantidadCotizadanumericUpDown.Value = 0;
            errorProvider.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Articulos articulos = LLenaClase();
            bool Paso = false;

            if (validar(2))
            {
                MessageBox.Show("Llenar Casillas");
            }
            else
            {

                if (ArticuloIDnumericUpDown.Value == 0)
                {
                    Paso = BLL.ArticuloBLL.Guardar(articulos);

                }
                else
                    Paso = BLL.ArticuloBLL.Editar(LLenaClase());

                if (Paso)
                {
                    MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevobutton_Click(articulos, e);
                    errorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("No se Pudo Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider.Clear();
                }
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticuloIDnumericUpDown.Value);

            if (validar(1))
            {
                MessageBox.Show("Llene Articulo ID");
            }
            else
            if (BLL.ArticuloBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo Eliminar", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.Clear();
            }

        }

        public bool validar(int error)
        {
            bool paso = false;

            if (error == 1 && ArticuloIDnumericUpDown.Value == 0)
            {
                errorProvider.SetError(ArticuloIDnumericUpDown, "Llenar Articulo ID");
                paso = true;
            }

            if (error == 2 && string.IsNullOrEmpty(FechamaskedTextBox.Text))
            {
                errorProvider.SetError(FechamaskedTextBox, "Llenar Fecha");
                paso = false;
            }

            if (error == 2 && string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "Lllenar Descripcion");
                paso = false;
            }

            if (error == 2 && PrecionumericUpDown.Value == 0)
            {
                errorProvider.SetError(PrecionumericUpDown, "Llenar Precio");
                paso = true;
            }
            if (error == 2 && ExistencianumericUpDown.Value == 0)
            {
                errorProvider.SetError(ExistencianumericUpDown, "Llenar Existencia");
                paso = true;
            }
            if (error == 2 && CantidadCotizadanumericUpDown.Value == 0)
            {
                errorProvider.SetError(CantidadCotizadanumericUpDown, "Llenar Cantidad Cotizada");
                paso = true;
            }
            return paso;
        }

    }
}
