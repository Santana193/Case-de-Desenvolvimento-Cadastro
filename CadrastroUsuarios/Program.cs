using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadrastroUsuarios
{
    class Program
    {
        static void Main()

        {
            GerenciadorUsuarios gerenciador = new GerenciadorUsuarios();
            bool executando = true;

            while (executando)
            {
                Console.WriteLine("\n  ====  Menu ====");
                Console.WriteLine("1 - Adicionar Usuário");
                Console.WriteLine("2 - Listar Usuários");
                Console.WriteLine("3 - Buscar Usuário");
                Console.WriteLine("4 - Sair");
                Console.Write("  Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Idade: ");
                        if (int.TryParse(Console.ReadLine(), out int idade))
                        {
                            gerenciador.AdicionarUsuario(nome, email, idade);
                        }

                        else
                        { 

                            Console.WriteLine("Idade inválida");
                        }

                        break;

                    case "2":
                        gerenciador.LisarUsuario();
                        break;

                    case "3":
                        Console.Write("\nDigite o nome do usuário para buscas: ");
                        string nomeBusca = Console.ReadLine();
                        gerenciador.BuscarUsuario(nomeBusca);
                        break;

                    case "4":
                        executando = false;
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                }
            }
        }
    }
