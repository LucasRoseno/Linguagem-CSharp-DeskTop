using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj027_Lucas_ClasseAbstratas.Classes
{
    public class ClsAluno : ClsPessoa
    {
        private string curso;
        private string turma;

        public string Curso { get => curso; set => curso = value; }
        public string Turma { get => turma; set => turma = value; }

        public ClsAluno()
        {
            curso = "";
            turma = "";
        }

        public override string Incluir()
        {
            return "Dados do aluno incluídos com sucesso:\n"
            +Cpf+"\n"
            +Nome+"\n"
            +Endereco+"\n"
            +Curso+ "\n"
            +Turma;

        }


    }
}
