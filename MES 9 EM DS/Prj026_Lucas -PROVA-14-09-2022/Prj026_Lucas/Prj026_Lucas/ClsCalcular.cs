using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj026_Lucas
{
    class ClsCalcular
    {
        private int _numero;

        public int Numero { set => _numero = value; }


        public ClsCalcular()
        {
            _numero = 0;
        }


      

        public string Verificar()
        {

            if (_numero <= 1)
            {
                return  " não é primo";
               
            }
        
            for (int divisor = 2; divisor < _numero; divisor++)
            {

                int resto = _numero % divisor;

                if (resto == 0)
                {
                    return "Não é primo";

                }
                


            }
            return "É Primo";


        }

       

        
    }
}

    