using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_mediante_listas_enlazadas
{
    public partial class Form1 : Form
    {
        Inventario prod = new Inventario();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto nuevo;
            nuevo = new Producto(Convert.ToInt16(txtCodigo.Text), txtNombre.Text, txtDesc.Text, txtCantidad.Text,
                txtCosto.Text);
            prod.llenar(nuevo);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text = prod.Listar();
        }
    }
}
