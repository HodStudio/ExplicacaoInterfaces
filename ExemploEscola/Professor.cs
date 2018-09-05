namespace ExemploEscola
{
    internal class Professor : Pessoa, IAplicador
    {
        public string Escolaridade { get; set; }
        public string Curso { get; set; }
        public string NumeroDiploma { get; set; }
        public int ValorPorHora { get; set; }

        public int CalcularSalarioExame(Exame exame) => ValorPorHora * exame.TempoExecucao / 60;
    }
}
