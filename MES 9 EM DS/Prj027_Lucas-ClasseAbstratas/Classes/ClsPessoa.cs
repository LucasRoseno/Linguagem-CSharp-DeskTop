using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj027_Lucas_ClasseAbstratas.Classes
{
   public abstract class  ClsPessoa
    {
        private string cpf;
        private string nome;
        private string endereco;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }


        public ClsPessoa() {
            cpf = "";
            nome = "";
            endereco = "";
        }

        public abstract string Incluir();

        public string Excluir() { return "Dados excluídos com sucesso!!!"; }





    }
}
