using System;

namespace StonatecConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("---Stonatec sistemas--- \n");
                Console.WriteLine("1 Cadastrar equipamentos");
                Console.WriteLine("2 Listar equipamentos");
                Console.WriteLine("0 Sair");
                Console.WriteLine("Digite a opção desejada: \n");
                opcao = Convert.ToInt32(Console.ReadLine());
            } while (opcao != 0);
        }
    }
}
