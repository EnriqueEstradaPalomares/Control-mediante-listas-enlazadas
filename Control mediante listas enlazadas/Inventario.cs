using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_mediante_listas_enlazadas
{
    class Inventario
    {
        private Producto inicio = null;
        public void llenar(Producto nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                agregar(nuevo, inicio); 
            }
        }

        private void agregar(Producto nuevo, Producto quien)
        {
            if (quien.sig != null)
                agregar(nuevo, quien.sig);
            else
                quien.sig = nuevo;
        }
        //--------------------------------------------------------------------------
        public string buscar(int codigo)
        {
            string data = "";
            Producto prod = Buscar(codigo, inicio);
            if (prod != null)
                data += prod.ToString() + "\r\n";
            return data;
        }

        private Producto Buscar(int codigo, Producto posicion)
        {
            if (posicion != null)
            {
                if (posicion.Codigo != codigo)
                    return Buscar(codigo, posicion.sig);
                else
                    return posicion;
            }
            else
                return null;
        }
        //--------------------------------------------------------------------------
        public void eliminar(int codigo)
        {
            Producto prod = Buscar(codigo, inicio);
            if(prod != null)
            {
                if (prod == inicio)
                    inicio = inicio.sig;
                else
                    prod = prod.sig;
            }
        }
        //--------------------------------------------------------------------------
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
        //----------------------------------------------------------------------------
        public void Insertar(Producto nuevo, int posicion)
        {
            Producto temp = inicio, temp2, elemento = Buscar(nuevo.Codigo, inicio);
            if (elemento == null)
            {
                int contador = 0;
                if (posicion == 1)
                {
                    temp2 = inicio;
                    inicio = nuevo;
                    inicio.sig = temp2;
                }
                else
                {
                    while (contador < posicion - 2)
                    {
                        temp = temp.sig;
                        contador++;
                    }
                    temp2 = temp.sig;
                    temp.sig = nuevo;
                    temp.sig.sig = temp2;
                }
            }
        }
        //----------------------------------------------------------------------------
        public void agregarInicio(Producto nuevo)
        {
            Producto temp = inicio, elemento = Buscar(nuevo.Codigo, inicio);
            if (elemento == null)
            {
                inicio = nuevo;
                inicio.sig = temp;
            }
        }
        //----------------------------------------------------------------------------
        public void eliminarPrimero()
        {
            if (inicio != null)
                inicio = inicio.sig;
        }
        //----------------------------------------------------------------------------
        public void eliminarUltimo()
        {
            if (inicio != null)
            {
                if (inicio.sig == null)
                    inicio = null;
                else
                    EliminarUltimo(inicio);
            }
        }

        public void EliminarUltimo(Producto posicion)
        {
            if (posicion.sig.sig == null)
                posicion.sig = null;
            else
                EliminarUltimo(posicion.sig);
        }
        //----------------------------------------------------------------------------
    }
}
