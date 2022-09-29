using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj024_Lucas
{
    class ClsClassificados
    {
        private int[] inscricao = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 1010 };
        private int numInscricao;

        public int NumInscricao { get => numInscricao; set => numInscricao = value; }

        public ClsClassificados(){
            numInscricao = 0;
        }

        public string Consultar()
        {
            int posicao = Array.IndexOf(inscricao, numInscricao) ;
            if (posicao < 0)
            {
                return  "Não há tal inscricao";
            }
            else
            {

                return  "Você foi classificado na " + (posicao+1) + " posicao";
            }

           
        }
        
        public string Limpar()
        {
            return "";
            
   }

        
    }
}
