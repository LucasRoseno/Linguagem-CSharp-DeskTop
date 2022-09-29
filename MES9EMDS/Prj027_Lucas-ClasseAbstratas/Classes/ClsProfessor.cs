using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj027_Lucas_ClasseAbstratas.Classes
{
    public class ClsProfessor : ClsPessoa
    {

        /* eu importei esses aqui em baixo do CLSPESSOA PARA CLSPROFESSOR
         private string cpf;
        private string nome;
        private string endereco;
             
             */

        private string licenciatura;
        private string categoria;

        public string Licenciatura { get => licenciatura; set => licenciatura = value; }
        public string Categoria { get => categoria; set => categoria = value; }


        public ClsProfessor()
        {
            licenciatura = "";
            categoria = "";

          
        }

        public override string Incluir()
        {
            return "Dados do professor incluídos com sucesso:\n"
                +Cpf+"\n"
                +Nome+"\n"
                +Endereco+"\n"
                +Licenciatura+"\n"
                +Categoria;

        }

    }
}
