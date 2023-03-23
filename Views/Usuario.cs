using Controllers;
using Models;
using System;

namespace View {
    class Usuario {
        public static void Show() {
            Console.WriteLine("Digite o id do usuario: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do usuario: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o email do usuario: ");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuario: ");
            string senha = Console.ReadLine();
            Controllers.Usuario.CadastrarUsuario(new Models.Usuario(id, nome, email, senha));
        }

        public static void ListarUsuario() {
            Controllers.Usuario.BuscarUsuario();
            Console.WriteLine("Usuarios Logados: ");
            if(Controllers.Middleware.BuscaUsuarioLogado() == null) {
                Console.WriteLine("Nenhum usuario logado");
            } else {
                foreach (Models.Sessao sessao in Controllers.Middleware.BuscaUsuarioLogado())
                {
                    Console.WriteLine(sessao);
                }
            }
            Console.WriteLine("Usuarios Administradores: ");
            if(Controllers.Middleware.BuscaUsuarioAdministrador() == null) {
                Console.WriteLine("Nenhum usuario administrador");
            } else {
                foreach (Models.Usuario item in Controllers.Middleware.BuscaUsuarioAdministrador())
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Usuarios Normais: ");
            if(Controllers.Middleware.BuscaUsuarioNormal() == null) {
                Console.WriteLine("Nenhum usuario normal");
            } else {
                foreach (Models.Usuario item in Controllers.Middleware.BuscaUsuarioNormal())
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void AtualizarUsuario() {
            Console.WriteLine("Digite o id do usuario: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do usuario: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o email do usuario: ");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuario: ");
            string senha = Console.ReadLine();
            Controllers.Usuario.AtualizarUsuario(new Models.Usuario(id, nome, email, senha));
        }

        public static void DeletarUsuario() {
            Console.WriteLine("Digite o id do usuario: ");
            int id = int.Parse(Console.ReadLine());
            Controllers.Usuario.DeletarUsuario(id);
        }
    } 
}