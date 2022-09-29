using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj023_POO_LPOO_Lucas
{
    class ClsOperacao
    {
        //Declaração de atributos (variaveis) e get's set's
        private int valor1;
        private int valor2;


        public int Valor1
        {
            get => valor1; set => valor1 = value;
        }
        public int Valor2 { get => valor2; set => valor2 = value; }

        //método construtor
        public ClsOperacao()
        {
            valor1 = 0;
            valor2 = 0;
        }

        public int Somar()
        {
            return valor1 + valor2;
        }

    }
}
