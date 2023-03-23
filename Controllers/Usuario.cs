using System;
using System.Collections;
using System.Collections.Generic;
using Models;

namespace Controllers {

    public class Usuario : IEnumerable<Models.Usuario>{

        public static void CadastrarUsuario(Models.Usuario usuario) {
           Models.Usuario.CadastrarUsuario(usuario);
        }

        public static void BuscarUsuario() {
            try {
                Models.Usuario.BuscarUsuario().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Email: {i.Email} Senha: {i.Senha}"));
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static List<Models.Usuario> BuscarUsuarioEmailSenha(string email, string senha) {
            return Models.Usuario.BuscarUsuarioEmailSenha(email, senha);
        }

        public static void AtualizarUsuario(Models.Usuario usuario) {
            Models.Usuario.AtualizarUsuario(usuario);
        }

        public static void DeletarUsuario(int id) {
            Models.Usuario.DeletarUsuario(id);
        }

        public IEnumerator<Models.Usuario> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}