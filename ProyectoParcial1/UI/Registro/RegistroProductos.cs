using ProyectoParcial1.BLL;
using ProyectoParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParcial1.UI.Registros
{
    public partial class RegistroProductos : Form
    {
        public RegistroProductos() => InitializeComponent();
        
        public  Productos LlenaClase()
        {
            Productos productos = new Productos();


            productos.Descripcion = DescripciontextBox.Text;
            productos.Existencia = ExistenciatextBox.Text;
            productos.Costo = CostotextBox.Text;
            productos.ValorInventario = ValorInventariotextBox.Text;


            return productos;

        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            Productos productos = BLL.ProductosBLL.Buscar((int)IdnumericUpDown.Value);

            if (ValidarForm())
            {
                if (productos == null)
                {
                    if (ProductosBLL.Guardar(LlenaClase()))
                    {
                        MessageBox.Show("Guardado Con Exito");
                       
                    }
                    else
                        MessageBox.Show("El Usuario No Se Guardo");
                   
                }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                Productos productos = BLL.ProductosBLL.Buscar(id);

                if (productos != null)
                {

                    DescripciontextBox.text = productos.Descripcion;
                    ExistenciatextBox.Text = productos.Existencia;
                    CostotexBox.Text = productos.Costo;
                    ValorInventariotexBox.Text = productos.ValorInventario;
                }
                else
                    MessageBox.Show("No se encontro!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarForm()
        {
            bool retorno = true;
            if (Descriptiontexbox.Text.Length == 0)
            {
                retorno = false;
            }
            else if (ExistenciatexBox.TextLength == 0)
            {
                retorno = false;
            }
            else if (CostotexBox.TextLength == 0)
            {
                retorno = false;
            }
            else if (ValorInventariotexBox.TextLength == 0)
            {
                retorno = false;
            }

        }
        
    
