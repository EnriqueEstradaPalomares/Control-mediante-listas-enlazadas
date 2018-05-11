using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_mediante_listas_enlazadas
{
    class Inventario
    {
        Producto inicio = null;
        public void llenar(Producto nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                Producto temp = inicio;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                    temp.sig = nuevo;
                }
            }
        }

        public string Listar()
        {
            string data = "";
            Producto t = inicio;
            while (t != null)
            {
                data += t.ToString() + "\r\n";
                t = t.sig;
            }
            return data;
        }
    }
}
