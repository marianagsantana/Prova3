using System;
using System.Collections;
using System.Collections.Generic;
using Models;

namespace Controllers {
    
    public class Sessao : IEnumerable<Models.Sessao> {
        
        public static void CadastrarSessao(Models.Sessao sessao) {
            Models.Sessao.CadastrarSessao(sessao);
        }
        
        public static void BuscarSessao() {
            try {
                Models.Sessao.BuscarSessao().ForEach(i => Console.WriteLine($"Id: {i.Id} Token: {i.Token} Data de Criação: {i.Criacao} Data de Expiração: {i.Limite}"));
            }
            catch (System.Exception) {
                throw new System.Exception("Erro ao buscar sessão");
            }
        }
        
        public static void DeletarSessao(int id) {
            Models.Sessao.DeletarSessao(id);
        }

        public IEnumerator<Models.Sessao> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}