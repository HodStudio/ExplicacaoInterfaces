using System.Collections.Generic;

namespace ExemploEscola
{
    internal class ProvaEscolar : Exame
    {
        public ProvaEscolar(Professor aplicador, List<string> perguntas, int tempoExecucao) : base(aplicador, perguntas, tempoExecucao) { }

        public override void Inscrever(IDiscente discente)
        {
            if (!Discentes.Contains(discente))
                Discentes.Add(discente);
        }
    }
}
