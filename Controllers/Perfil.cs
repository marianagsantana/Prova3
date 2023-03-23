using System;
using System.Collections;
using System.Collections.Generic;
using Models;

namespace Controllers {

    public class Perfil : IEnumerable<Models.Perfil> {

        public static void CadastrarPerfil(Models.Perfil perfil) {
            Models.Perfil.CadastrarPerfil(perfil);
        }

        public static void BuscarPerfil() {
            try {
                Models.Perfil.BuscarPerfil().ForEach(i => Console.WriteLine($"Id: {i.Id} Administrador: {i.Admnistrador} Id do Usuario: {i.Usuario_id}"));
            }
            catch (System.Exception) {
                throw new System.Exception("Erro ao buscar perfil");
            }
        }

        public static void AtualizarPerfil(Models.Perfil perfil) {
            Models.Perfil.AtualizarPerfil(perfil);
        }

        public static void DeletarPerfil(int id) {
            Models.Perfil.DeletarPerfil(id);
        }

        public IEnumerator<Models.Perfil> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}