using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev
{
    public class Professor : Pessoa
    {
        public string Materia { get; set; }
        public decimal Salario { get; set; }
        public int Matricula { get; set; }

        public List<Aluno> Alunos { get; set; }

        public void AprovarAlunos()
        {
            foreach (var aluno in Alunos)
            {
                if (aluno.Nota >= 5)
                {
                    Console.WriteLine("Aluno " + aluno.Nome + " aprovado com nota: " + aluno.Nota + " na matéria " + Materia);
                }
                else 
                {
                    Console.WriteLine("Aluno " + aluno.Nome + " reprovado com nota: " + aluno.Nota + " na matéria " + Materia);
                }
            }
        }

    }
}
