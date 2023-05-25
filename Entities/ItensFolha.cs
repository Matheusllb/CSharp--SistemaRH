using System.Collections.Generic;

namespace Pim3Semestre.Entities
{
    public class ItensFolha
    {
        public int Id { get; private set; }
        public decimal DescontoTotal { get; private set; }
        public decimal BeneficioTotal { get; private set; }
        public List<BeneficioDesconto> ListaBenDes { get; private set; } = new List<BeneficioDesconto> { };

        public ItensFolha(int id)
        {
            Id = id;
        }

        public void AdicionarBeneficioDesconto(BeneficioDesconto benDes)
        {
                ListaBenDes.Add(benDes);
        }

        public void RemoverBeneficioDesconto(BeneficioDesconto benDes)
        {
            ListaBenDes.Remove(benDes);
        }

        public int Quantidade()
        {
            return ListaBenDes.Count();
        }

        public void CalculaTotal()
        {
            foreach(BeneficioDesconto item in ListaBenDes) 
            {
                if (item.Valor != 0)
                {
                    if(item.Desconto is true)
                    {
                        DescontoTotal += item.Valor;
                    }
                    else
                    {
                        BeneficioTotal += item.Valor;
                    }
                }
            }
        }
    }
}
