using System;

namespace ExemploEscola
{
    internal class Aluno : Pessoa, IDiscente
    {
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
