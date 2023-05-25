using Pim3Semestre.Entities.Enums;

namespace Pim3Semestre.Entities
{
    public class Cidade
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Estado Uf { get; private set; }

        public Cidade(int id, string nome, Estado uf)
        {
            Id = id;
            Nome = nome;
            Uf = uf;
        }
    }
}
