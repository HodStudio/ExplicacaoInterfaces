using System.Collections.Generic;

namespace ExemploEscola
{
    internal class ExameVestibular : Exame
    {
        public ExameVestibular(Monitor aplicador, List<string> perguntas, int tempoExecucao) : base(aplicador, perguntas, tempoExecucao) { }

        public void Inscrever(Candidato candidato) => base.Inscrever(candidato);
    }
}
