namespace Pim3Semestre.Entities
{
    public class Salario
    {
        public int Id { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataInicio { get; private set; }
        public Funcionario Funcionario { get; private set; }
        public Cargo Cargo { get; private set; }

        public Salario(int id, decimal valor, DateTime dataInicio, Funcionario funcionario, Cargo cargo)
        {
            Id = id;
            Valor = valor;
            DataInicio = dataInicio;
            Funcionario = funcionario;
            Cargo = cargo;
        }


    }
}
