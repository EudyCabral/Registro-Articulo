using Registro_Articulo.UI.Consultar;
using Registro_Articulo.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registro_Articulo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_de_Articulos registro = new Registro_de_Articulos();
            registro.Show();
        }

        private void articuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultar_de_Articulos consultar = new Consultar_de_Articulos();
            consultar.Show();
        }
    }
}
