using System;
using System.Collections.Generic;

namespace StonatecConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Cliente c = new Cliente();
            List<Cliente> clientes = new List<Cliente>();
            do
            {
                Console.Clear();
                Console.WriteLine("---Stonatec sistemas--- \n");
                Console.WriteLine("1 Cadastrar cliente");
                Console.WriteLine("2 Listar cliente");
                Console.WriteLine("0 Sair");
                Console.WriteLine("Digite a opção desejada: \n");

                int v = Convert.ToInt32(Console.ReadLine());
                opcao = v;
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        c = new Cliente();
                        Console.WriteLine("Cadastrar cliente \n");
                        Console.WriteLine("Digite o nome: \n");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o cpf: \n");
                        c.Cpf = Console.ReadLine();
                       
                        if (clientes.Count == 0)
                        {
                            clientes.Add(c);
                            Console.WriteLine("Cliente salvo com sucesso...");
                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Cliente clienteCadastrado in clientes)
                            {
                                if (clienteCadastrado.Cpf == c.Cpf)
                                {
                                    encontrado = true;
                                }
                            }
                            if (!encontrado)
                            {
                                clientes.Add(c);
                                Console.WriteLine("Cliente salvo com sucesso!!!");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível adicionar.");
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Listar Equipamentos \n");
                        foreach (Cliente clienteCadastrado in clientes)
                        {
                            Console.WriteLine(clienteCadastrado);
                        }
                        Console.ReadKey();
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
