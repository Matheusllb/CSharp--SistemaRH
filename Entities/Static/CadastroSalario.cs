using System.Globalization;

namespace Pim3Semestre.Entities.Static
{
    public class CadastroSalario
    {
        
        public Salario TelaCadastro(Funcionario funcionario, Cargo cargo)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("--------------------NOVO SALARIO--------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados Salariais:");
            Random random = new Random(); //Processo temporario para salvar id sem que o usuario tenha que informa-lo
            int id = random.Next();       // Random gera numero aleatorio e id recebe
            Console.Write("Valor R$: ");
            decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Data de início (dd/MM/yyyy): ");
            DateTime dataInicio = DateTime.Parse(Console.ReadLine());
            Console.Clear();
            Salario novoSalario = new Salario(id, valor, dataInicio, funcionario, cargo);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("--------------------SALARIO REGISTRADO--------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
            return novoSalario;
        }
    }
}
