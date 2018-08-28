using System;

namespace ExemploEscola
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        public string NomeResponsavel { get; set; }
        public string EmailResponsavel { get; set; }
        public string CelularResponsavel { get; set; }

        public string Matricula { get; set; }
        public DateTime DataMatricula { get; set; }
        public string Turno { get; set; }
        public int Serie { get; set; }
        public string Turma { get; set; }
    }
}
