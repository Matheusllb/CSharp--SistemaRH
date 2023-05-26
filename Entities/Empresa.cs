namespace Pim3Semestre.Entities
{
    public class Empresa
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cnpj { get; private set; }
        public string Setor { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public Endereco Endereco { get; private set; }

        public Empresa() { }

        public Empresa(int id, string nome, string cnpj, string setor, string email, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            Setor = setor;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
