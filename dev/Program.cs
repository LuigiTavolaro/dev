using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev
{
    class Program
    {
        static void Main(string[] args)
        {

            Professor professor = new Professor();
            Aluno aluno;


            professor.Nome = "Luigi";
            professor.Salario = 5000.0M;
            professor.Matricula = 1;
            professor.Materia = "Lógica I";
            professor.Idade = 35;
            professor.Genero = "M";
            professor.Alunos = new List<Aluno>();
            aluno = RetornarAlunoJoao();

            professor.Alunos.Add(aluno);
            aluno = RetornarAlunoMaria();
            professor.Alunos.Add(aluno);
            professor.AprovarAlunos();

            Console.ReadLine();
        }

        private static Aluno RetornarAlunoJoao()
        {
            Aluno aluno = new Aluno();

            aluno.Nome = "Joao";
            aluno.Matricula = 1;
            aluno.Genero = "M";
            aluno.Idade = 18;

            aluno.FazerProva();
            return aluno;
        }
        private static Aluno RetornarAlunoMaria()
        {
            Aluno aluno = new Aluno();

            aluno.Nome = "Maria";
            aluno.Matricula = 2;
            aluno.Genero = "F";
            aluno.Idade = 19;

            aluno.FazerProva();
            return aluno;
        }
    }
}
