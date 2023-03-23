using Controllers;
using Models;
using System;

namespace View {

    class Perfil {
        public static void Show() {
            Console.WriteLine("Digite o id do perfil: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o id do usuario: ");
            int idUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite se o perfil é administrador: ");
            int admin = int.Parse(Console.ReadLine());
            if(admin == 1) {
                Controllers.Perfil.CadastrarPerfil(new Models.Perfil(id, idUsuario, true ));
            } else if(admin == 0){
                Controllers.Perfil.CadastrarPerfil(new Models.Perfil(id, idUsuario, false));
            } else {
                Console.WriteLine("Valor inválido");
            }
        }

        public static void ListarPerfil() {
            Controllers.Perfil.BuscarPerfil();
        }

        public static void AtualizarPerfil() {
            Console.WriteLine("Digite o id do perfil: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o id do usuario: ");
            int idUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite se o perfil é administrador: ");
            bool administrador = bool.Parse(Console.ReadLine());
            int admin = int.Parse(Console.ReadLine());
            if(admin == 1) {
                Controllers.Perfil.AtualizarPerfil(new Models.Perfil(id, idUsuario, true ));
            } else if(admin == 0){
                Controllers.Perfil.AtualizarPerfil(new Models.Perfil(id, idUsuario, false));
            } else {
                Console.WriteLine("Valor inválido");
            }
        }

        public static void DeletarPerfil() {
            Console.WriteLine("Digite o id do perfil: ");
            int id = int.Parse(Console.ReadLine());
            Controllers.Perfil.DeletarPerfil(id);
        }
    }
}