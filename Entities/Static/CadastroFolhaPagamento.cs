using System.Globalization;

namespace Pim3Semestre.Entities.Static
{
    public class CadastroFolhaPagamento
    {
        public FolhaPagamento TelaCadastro(Empresa empresa, Salario salBruto, ItensFolha itens)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("--------------------NOVA FOLHA-DE-PAGAMENTO--------------------");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados Iniciais:");
            Random random = new Random(); //Processo temporario para salvar id sem que o usuario tenha que informa-lo
            int id = random.Next();       // Random gera numero aleatorio e id recebe
            Console.Write("Data do pagamento: ");
            DateTime dataPag = DateTime.Parse(Console.ReadLine());
            Console.Write("Hora-extra: ");
            decimal horaExtra = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();
            FolhaPagamento novaFolhaP = new FolhaPagamento(id, empresa, dataPag, salBruto, horaExtra, itens);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------FOLHA REGISTRADA--------------------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
            return novaFolhaP;
        }
    }
}
