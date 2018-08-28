using System.Collections.Generic;

namespace ExemploEscola
{
    internal abstract class Exame
    {
        public IAplicador Aplicador { get; set; }
        public List<string> Perguntas { get; set; }
        public List<IDiscente> Discentes { get; set; }
        public int TempoExecucao { get; set; }

        public Exame(IAplicador aplicador, List<string> perguntas, int tempoExecucao)
        {
            Aplicador = aplicador;
            Perguntas = perguntas;
            TempoExecucao = tempoExecucao;
            Discentes = new List<IDiscente>();
        }

        public abstract void Inscrever(IDiscente discente);
    }
}
