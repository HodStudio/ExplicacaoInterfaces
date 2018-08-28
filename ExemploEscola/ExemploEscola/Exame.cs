using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploEscola
{
    class Exame
    {
        public Professor Professor { get; set; }
        public List<string> Perguntas { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Exame(Professor professor, List<string> perguntas)
        {
            Professor = professor;
            Perguntas = perguntas;
            Alunos = new List<Aluno>();
        }

        public void InscreverAluno(Aluno aluno)
        {
            if (!Alunos.Contains(aluno))
                Alunos.Add(aluno);
        }
    }
}
