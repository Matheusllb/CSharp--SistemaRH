using Pim3Semestre.Entities.Enums;

namespace Pim3Semestre.Entities
{
    abstract public class Pessoa
    {
        public int Id { get; protected set; }
        public Endereco Endereco { get; protected set; }
        public string Nome { get; protected set; }
        public string Cpf { get; protected set; }
        public EstadoCivil EstadoCivil { get; protected set; }

        public Pessoa(int id, Endereco endereco, string nome, string cpf, EstadoCivil estadoCivil)
        {
            Id = id;
            Endereco = endereco;
            Nome = nome;
            Cpf = cpf;
            EstadoCivil = estadoCivil;
        }
    }
}
