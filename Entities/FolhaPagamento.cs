namespace Pim3Semestre.Entities
{
    public class FolhaPagamento
    {
        public int Id { get; private set; }
        public Empresa Empresa { get; private set; }
        public DateTime DataFechamento { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public decimal TotalVencimentos { get; private set; }
        public decimal TotalDescontos { get; private set; }
        public decimal TotalLiquido { get; private set; }
        public Salario SalarioBruto { get; private set; }
        public decimal SalarioINSS { get; private set; }
        public decimal ValorFGTS { get; private set; }
        public decimal ValorIRRF { get; private set; }
        public ItensFolha Itens { get; private set; }
        public decimal HoraExtra { get; private set; }

        public FolhaPagamento(int id, Empresa empresa, DateTime pagamento,
         Salario salarioBruto, decimal horaExtra, ItensFolha itens)
        {
            Id = id;
            Empresa = empresa;
            DataFechamento = DateTime.Now;
            DataPagamento = pagamento;
            SalarioBruto = salarioBruto;
            HoraExtra = horaExtra;
            Itens = itens;
        }

        public void CalculaFGTS()
        {
            ValorFGTS = SalarioBruto.Valor * (decimal)0.08;
        }
        public void CalculaINSS()
        {
            if(SalarioBruto.Valor <= 1320)
            {
                SalarioINSS = SalarioBruto.Valor * (decimal)0.075;
            }
            else if(SalarioBruto.Valor >= 1321 || SalarioBruto.Valor <= (decimal)2571.29)
            {
                SalarioINSS = SalarioBruto.Valor * (decimal)0.09;
            }
            else if(SalarioBruto.Valor >= (decimal)2571.30 || SalarioBruto.Valor <= (decimal)3856.94)
            {
                SalarioINSS = SalarioBruto.Valor * (decimal)0.12;
            }
            else if(SalarioBruto.Valor > (decimal)3856.95)
            {
                SalarioINSS = SalarioBruto.Valor * (decimal)0.14;
            }
        }
        public void CalculaIRRF()
        {
            decimal bCIRRF = SalarioBruto.Valor - SalarioINSS;
            if (bCIRRF >= (decimal)1903.99 || bCIRRF <= (decimal)2826.65)
            {
                ValorIRRF = bCIRRF * (decimal)0.075;
            }
            else if(bCIRRF >= (decimal)2826.66 || bCIRRF <= (decimal)3751.05)
            {
                ValorIRRF = bCIRRF * (decimal)0.15;
            }
            else if(bCIRRF >= (decimal)3751.06 || bCIRRF <= (decimal)4664.68)
            {
                ValorIRRF = bCIRRF * (decimal)0.225;
            }
            else if(bCIRRF > (decimal)4664.68)
            {
                ValorIRRF = bCIRRF * (decimal)0.275;
            }
        }

        public void CalculaTotalVencimentos()
        {
            TotalVencimentos = SalarioBruto.Valor + Itens.BeneficioTotal + HoraExtra;

        }
        public void CalculaTotalDescontos()
        {
            TotalDescontos = SalarioINSS + ValorIRRF + Itens.DescontoTotal;
        }
        public void CalculaTotalLiquido()
        {
            TotalLiquido = SalarioBruto.Valor - TotalDescontos;
        }
    }
}
