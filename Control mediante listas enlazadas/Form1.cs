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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            prod.buscar(Convert.ToInt32(txtCodigo.Text));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            prod.eliminar(Convert.ToInt32(txtCodigo.Text));
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto nuevo;
            nuevo = new Producto(Convert.ToInt16(txtCodigo.Text), txtNombre.Text, txtDesc.Text, txtCantidad.Text,
                txtCosto.Text);
            prod.Insertar(nuevo, Convert.ToInt16(txtPos.Text));
        }

        private void btnAgrInicio_Click(object sender, EventArgs e)
        {
            Producto nuevo;
            nuevo = new Producto(Convert.ToInt16(txtCodigo.Text), txtNombre.Text, txtDesc.Text, txtCantidad.Text,
                txtCosto.Text);
            prod.agregarInicio(nuevo);
        }
    }
}
