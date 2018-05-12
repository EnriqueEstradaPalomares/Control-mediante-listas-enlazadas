using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_mediante_listas_enlazadas
{
    class Producto
    {
        private int _codigo;
        private string _nombre;
        private string _descripcion;
        private string _cantidad;
        private string _costo;

        private Producto _sig;

        public Producto(int codigo, string nombre, string desc, string cantidad, string costo)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._descripcion = desc;
            this._cantidad = cantidad;
            this._costo = costo;
        }
        public int Codigo
        {
            get { return _codigo; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }

        public string Cantidad
        {
            get { return _cantidad; }
        }

        public string Costo
        {
            get { return _costo; }
        }

        public Producto sig
        {
            get { return _sig; }
            set { _sig = value; }
        }

        public override string ToString()
        {
            return "Codigo: " + Codigo + "| Nombre: " + Nombre + "| Descripcion: " + Descripcion +
                    "| Cantidad: " + Cantidad + "| Precio: $" + Costo + "\r\n";
        }
    }
}
