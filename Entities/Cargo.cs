namespace Pim3Semestre.Entities
{
    public class Cargo
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Empresa Empresa { get; private set; }

        public Cargo(int id, string nome, Empresa empresa) 
        {
            Id = id;
            Nome = nome;
            Empresa = empresa;
        }
    }
}
