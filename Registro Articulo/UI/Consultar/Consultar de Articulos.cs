
using Registro_Articulo.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;



namespace Registro_Articulo.UI.Consultar
{
    public partial class Consultar_de_Articulos : Form
    {
        public Consultar_de_Articulos()
        {
            InitializeComponent();
        }

        private void Consultar_de_Articulos_Load(object sender, EventArgs e)
        {

        }

     

        //Metodo de validacion  de todos los posible errores que se puedan  dar en el formulario

        private bool Validar(int error)
        {
            bool paso = false;
            int num = 0;

            if (error == 1 && string.IsNullOrEmpty(CriteriotextBox.Text))
            {
                errorProvider.SetError(CriteriotextBox, "Por Favor, LLenar Casilla!");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out num) == false)
            {
                errorProvider.SetError(CriteriotextBox, "Debe Digitar un Numero");
                paso = true;
            }

            if (error == 3 && int.TryParse(CriteriotextBox.Text, out num) == true)
            {
                errorProvider.SetError(CriteriotextBox, "Debe Digitar Caracteses");
                paso = true;
            }

            return paso;
        }

        //Busca una Entidad en la base de datos y la muestra
        //Comparando con cada uno de los casos del switch
        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            //Inicializacion del filtro en True
            Expression<Func<Articulos, bool>> filtro = X => true;

            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {

                case 0://Todo

                    ConsultardataGridView.DataSource = BLL.ArticuloBLL.GetList(filtro); // Muesta la lista completa de entidade que se encuentran en la 
                                                                                        //base de datos                                    

                    break;

                case 1: //ID

                    if (Validar(1))
                    { MessageBox.Show("Por Favor Llene Casilla"); }
                    else
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero");
                    }
                    else

                    {

                        id = Convert.ToInt32(CriteriotextBox.Text);
                        filtro = x => x.ArticuloId == id;                              // aqui se busca una entidad por el id y lo lista     
                        if (BLL.ArticuloBLL.GetList(filtro).Count() == 0)
                        {
                            errorProvider.Clear();
                            MessageBox.Show("Este ID no Existe");

                            return;
                        }
                        else
                        {

                            errorProvider.Clear();
                            ConsultardataGridView.DataSource = BLL.ArticuloBLL.GetList(filtro);// aqui lo lista en el datagridview

                        }



                    }

                    break;

                case 2://Fecha



                    if (Validar(1))
                    { MessageBox.Show("Por Favor Llene Casilla"); }
                    else
                    if (Validar(3))
                    { MessageBox.Show("Debe Digitar una Fecha"); }
                    else

                    {
                        filtro = x => x.FechaVencimiento.Equals(CriteriotextBox.Text);
                        if (BLL.ArticuloBLL.GetList(filtro).Count() == 0)  // se busca una entidad por la fecha
                        {
                            errorProvider.Clear();
                            MessageBox.Show("Esta Fecha no Existe");
                            return;
                        }
                        else

                            errorProvider.Clear();
                        ConsultardataGridView.DataSource = BLL.ArticuloBLL.GetList(filtro);
                    }

                    break;

                case 3://Precio

                    if (Validar(1))
                    {
                        MessageBox.Show("Por Favor Llene Casilla");
                    }
                    else
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Precio");
                    }
                    else
                    {
                        decimal p = Convert.ToDecimal(CriteriotextBox.Text);
                        filtro = x => x.Precio == p;                          //se busca una entidad por el precio
                        if (BLL.ArticuloBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Precio No Existe");
                            return;
                        }
                        else


                            errorProvider.Clear();
                        ConsultardataGridView.DataSource = BLL.ArticuloBLL.GetList(filtro);

                    }

                    break;


            }
            CriteriotextBox.Clear();


        }

        private void Imprimirbutton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("No hay Impresora Conectada");
        }
    }
}
