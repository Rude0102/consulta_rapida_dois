namespace consulta_rapida.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string nomePaciente { get; set; }
        public DateTime horaConsulta { get;set; }
        public string especialidade { get; set; }

    }
}