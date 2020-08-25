using System;

namespace StonatecConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Equipamento e = new Equipamento();
            do
            {
                Console.Clear();
                Console.WriteLine("---Stonatec sistemas--- \n");
                Console.WriteLine("1 Cadastrar Equipamentos");
                Console.WriteLine("2 Listar Equipamentos");
                Console.WriteLine("0 Sair");
                Console.WriteLine("Digite a opção desejada: \n");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastrar Equipamentos \n");
                        Console.WriteLine("Digite o nome do Equipamento: \n");
                        e.Equipamentos = Console.ReadLine();
                        Console.WriteLine("Digite o modelo do equipamento: \n");
                        e.Modelo = Console.ReadLine();
                        Console.WriteLine($"Equipamento: {e.Equipamentos} e modelo: {e.Modelo}\n");




                        break;
                    case 2:
                        Console.WriteLine("Listar Equipamentos \n");
                        break;
                    case 3:
                        Console.WriteLine("Saindo... \n");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida... \n");
                        break;
                }
                Console.WriteLine("\nPressione uma tecla para continuar...\n");
                Console.ReadKey();

            } while (opcao != 0);
        }
    }
}
