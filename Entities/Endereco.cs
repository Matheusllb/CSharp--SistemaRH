namespace Pim3Semestre.Entities
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string NomeLogradouro { get; private set; }
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public Cidade Cidade { get; private set; }

        public Endereco(int id, string nomeLogradouro, int numero, string bairro, string cep, Cidade cidade)
        {
            Id = id;
            NomeLogradouro = nomeLogradouro;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
        }
    }
}
