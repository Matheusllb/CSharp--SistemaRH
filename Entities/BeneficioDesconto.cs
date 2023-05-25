namespace Pim3Semestre.Entities
{
    public class BeneficioDesconto
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public bool Desconto { get; private set; }
        public decimal Valor { get; private set; }

        public BeneficioDesconto(int id, string descricao,bool desconto)
        {
            Id = id;
            Descricao = descricao;
            Desconto = desconto;
        }

        public BeneficioDesconto(int id, string descricao, bool desconto, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Desconto = desconto;
            Valor = valor;
        }
    }
}
