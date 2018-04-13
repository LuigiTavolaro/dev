using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev
{
    public class Aluno : Pessoa
    {

        public int Matricula { get; set; }
        public int Nota { get; set; }

        public void FazerProva()
        {

            Random rnd = new Random();
            Nota = rnd.Next(1, 10); // creates a number between 1 and 12
        }
    }
}
