using Lista_Doblemente_Enlazada_Circular_N_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace multiBrigada
{
    class  TLista3  :TLista
    {

        public TLista3() { }

        public void  crearlista(string brigada,int id,string nombre)
        {
            Insertar(new TNodo(brigada, id, nombre));
        }

        public bool Buscarbrigada(int nB)
        {
            TNodo p;
            bool aux = false;
            p = (TNodo)GetPrimero();
            while(p!=null)
            {
                if(p.getmibrigada()==nB)
                {
                    aux = true;
                    Cursor = p;
                    break;
                }
                p = (TNodo)p.PENodo;
            }
            return aux;
        }

    }
}