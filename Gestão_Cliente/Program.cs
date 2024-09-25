using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Gestão
{
    class Program
    {
        static List<Cliente> c = new List<Cliente>();
        static void Main(string[] args)
        {
            bool sair = true;
            
            while (sair)
            {
                Console.Clear();
                Console.WriteLine("\nMenu");
                Console.WriteLine("1 - Adicionar cliente");
                Console.WriteLine("2 - Consultar clientes");
                Console.WriteLine("3 - Remover cliente");
                Console.WriteLine("4 - Editar cliente");
                Console.WriteLine("5 - Sair");
                Console.Write("\nEscolha uma opção: ");

                string opcao = Console.ReadLine();
                switch (opcao) 
                {
                    case "1": 
                        Console.Clear();
                        AddClient();
                        break;
                    case "2":
                        Console.Clear(); 
                        ConsultClient();
                        break;
                    case "3":
                        Console.Clear(); 
                        RemoveClient();
                        break;
                    case "4":
                        Console.Clear(); 
                        EditClient();
                        break;
                    case "5": sair = false;
                        break;
                        default: 
                        Console.WriteLine("\nOPÇÃO INVALIDA!!");
                        Console.Write("\nPessione ENTER para escolher novamente.");
                        Console.ReadLine();
                        break;
                }
            }
        }
       
        static void AddClient()
        {
            Console.Write("\nDigite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o endereço: ");
            string endereço = Console.ReadLine();
            Console.Write("Digite o email: ");
            string email = Console.ReadLine();
            Console.Write("Digite o telefone: ");
            string telefone = Console.ReadLine();

            Cliente nClient = new Cliente(nome,endereço,email,telefone);
            c.Add(nClient);
            Console.WriteLine("\nCliente adicionado com sucesso!!");
            Console.Write("\nPessione ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void ConsultClient()
        {
            if (c.Count != 0)
            {
                Console.WriteLine("\nClientes cadastrados: ");
                foreach (var c in c)
                {
                    Console.WriteLine(c.MostrarDados());
                }
                Console.Write("\nPessione ENTER para voltar ao menu.");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("\nNão há clientes cadastrados ainda!");
                Console.Write("\nPessione ENTER para voltar para o menu.");
                Console.ReadLine();
            }
        }

        static void RemoveClient()
        {
            if (c.Count != 0)
            {
                Console.Write("Digite o nome do cliente que deseja remover: ");
                string nome = Console.ReadLine();

                Cliente nClient = c.Find(Cliente => Cliente.NomePessoa == nome);
                {
                    if (nClient != null)
                    {
                        c.Remove(nClient);
                        Console.WriteLine("\nCliente removido com sucesso!!");
                        Console.Write("\nPessione ENTER para voltar para o menu.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("\nCliente não encontrado!!");
                        Console.Write("\nPessione ENTER para voltar para o menu.");
                        Console.ReadLine();
                    }
                }
            }
            else 
            {
                Console.WriteLine("\nNão há clientes cadastrados ainda!");
                Console.Write("\nPessione ENTER para voltar para o menu.");
                Console.ReadLine();
            }
        }
        static void EditClient()
        {
            if (c.Count != 0)
            {
                Console.Write("Digite o nome do cliente que deseja editar: ");
                string nome = Console.ReadLine();

                Cliente nClient = c.Find(Cliente => Cliente.NomePessoa == nome);
                foreach (var c in c)
                {
                    if (nClient != null)
                    {
                        Console.Write("Digite o novo endereço: ");
                        nClient.EndereçoPessoa = Console.ReadLine();
                        Console.Write("Digite o novo email: ");
                        nClient.EmailPessoa = Console.ReadLine();
                        Console.Write("Digite o novo telefone: ");
                        nClient.TelefonePessoa = Console.ReadLine();

                        Console.WriteLine("\nCliente editado com sucesso!!");
                        Console.Write("\nPessione ENTER para voltar para o menu.");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("\nCliente não encontrado!!");
                        Console.Write("\nPessione ENTER para voltar para o menu.");
                        Console.ReadLine();
                    }
                }
            }
            else 
            {
                Console.WriteLine("\nNão há clientes cadastrados ainda!");
                Console.Write("\nPessione ENTER para voltar para o menu.");
                Console.ReadLine();
            }
        }


    }
}