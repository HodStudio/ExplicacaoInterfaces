using System.Collections.Generic;

namespace ExemploEscola
{
    internal class ProvaEscolar : Exame
    {
        public ProvaEscolar(Professor aplicador, List<string> perguntas, int tempoExecucao) : base(aplicador, perguntas, tempoExecucao) { }

        public void Inscrever(Aluno aluno) => base.Inscrever(aluno);
    }
}
