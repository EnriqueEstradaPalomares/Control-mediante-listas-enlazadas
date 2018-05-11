using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_mediante_listas_enlazadas
{
    class Producto
    {
        private int _codigo { get; set; }
        private string _nombre { get; set; }
        private string _descripcion { get; set; }
        private string _cantidad { get; set; }
        private string _costo { get; set; }

        private Producto _sig;

        public Producto(int codigo, string nombre, string desc, string cantidad, string costo)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._descripcion = desc;
            this._cantidad = cantidad;
            this._costo = costo;
        }

        public Producto sig
        {
            get { return _sig; }
            set { _sig = value; }
        }

        public override string ToString()
        {
            return "Codigo: " + _codigo + "| Nombre: " + _nombre + "| Descripcion: " + _descripcion +
                    "| Cantidad: " + _cantidad + "| Precio: $" + _costo + "\r\n";
        }
    }
}
