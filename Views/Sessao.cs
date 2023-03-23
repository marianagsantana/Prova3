using Controllers;
using Models;
using System;
using System.Collections.Generic;

namespace View {
        class Sessao {
            public static void Show() {
                Console.WriteLine("Digite o id da sessao: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o email do usuário: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite a senha do usuário: ");
                string senha = Console.ReadLine();
                List<Models.Usuario> usuario = Controllers.Usuario.BuscarUsuarioEmailSenha(email, senha);
                int idUsuario = usuario[0].Id;
                string token = Guid.NewGuid().ToString();
                DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = DateTime.Now.AddHours(2); 
                Controllers.Sessao.CadastrarSessao(new Models.Sessao(id, token, dataCriacao, dataExpiracao, idUsuario));
            }

            public static void ListarSessao() {
                Controllers.Sessao.BuscarSessao();
            }

            public static void DeletarSessao() {
                Console.WriteLine("Digite o email do usuário: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite a senha do usuário: ");
                string senha = Console.ReadLine();
                List<Models.Usuario> usuario = Controllers.Usuario.BuscarUsuarioEmailSenha(email, senha);
                int idUsuario = usuario[0].Id;
                Controllers.Sessao.DeletarSessao(idUsuario);
            }
    
        }
    }