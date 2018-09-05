namespace ExemploEscola
{
    internal class Monitor : Pessoa, IAplicador
    {
        public Professor Orientador { get; set; }
        public int ValorPorCandidato { get; set; }

        public int CalcularSalarioExame(Exame exame) => ValorPorCandidato * exame.Discentes.Count;
    }
}
