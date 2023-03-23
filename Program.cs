using System;
using View;

namespace Menu
{
    class Menu
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("==================================");
                Console.WriteLine("1 - Cadastrar Usuario");
                Console.WriteLine("2 - Listar Usuario");
                Console.WriteLine("3 - Atualizar Usuario");
                Console.WriteLine("4 - Deletar Usuario");
                Console.WriteLine("5 - Cadastrar Perfil");
                Console.WriteLine("6 - Listar Perfil");
                Console.WriteLine("7 - Atualizar Perfil");
                Console.WriteLine("8 - Deletar Perfil");
                Console.WriteLine("9 - Logar Sessao");
                Console.WriteLine("10 - Listar Sessao");
                Console.WriteLine("11 - Deletar Sessao");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("==================================");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao) {
                    case 1:
                        Usuario.Show();
                        break;
                    case 2:
                        Usuario.ListarUsuario();
                        break;
                    case 3:
                        Usuario.AtualizarUsuario();
                        break;
                    case 4:
                        Usuario.DeletarUsuario();
                        break;
                    case 5:
                        Perfil.Show();
                        break;
                    case 6:
                        Perfil.ListarPerfil();
                        break;
                    case 7:
                        Perfil.AtualizarPerfil();
                        break;
                    case 8:
                        Perfil.DeletarPerfil();
                        break;
                    case 9:
                        Sessao.Show();
                        break;
                    case 10:
                        Sessao.ListarSessao();
                        break;
                    case 11:
                        Sessao.DeletarSessao();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while(opcao != 0);
        }
    }
}
