using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Models {
    public class Sessao {
        public int Id { get; set; }
        public string Token { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Limite { get; set; }
        public Usuario Usuario { get; set; }
        public int Usuario_id { get; set; }
        public Sessao(int id, string token, DateTime criacao, DateTime limite, int usuario_id) {
            Id = id;
            Token = token;
            Criacao = criacao;
            Limite = limite;
            Usuario_id = usuario_id;
        }

        public override string ToString() {
            return $"Id: {Id} | Token: {Token} | Data de criação: {Criacao} | Data de expiração: {Limite} | Usuario: {Usuario_id}";
        }

        public static void CadastrarSessao(Sessao sessao) {
            try {
                using (Context context = new Context()) {
                    if(Models.Sessao.BuscarSessaoId(sessao.Usuario_id) != null)
                        throw new System.Exception("Sessão já cadastrada");
                    context.Sessoes.Add(sessao);
                    context.SaveChanges();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao cadastrar sessão");
            }
        }

        public static List<Sessao> BuscarSessao() {
            try {
                using (Context context = new Context()) {
                    return context.Sessoes.ToList();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao buscar sessão");
            }
        }

        public static Sessao BuscarSessaoId(int id) {
            try {
                using (Context context = new Context()) {
                    return context.Sessoes.Where(u => u.Id == id).FirstOrDefault();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao buscar sessão");
            }
        }

        public static void DeletarSessao(int id) {
            try {
                using (Context context = new Context()) {
                    Sessao sessao = context.Sessoes.Where(u => u.Id == id).FirstOrDefault();
                    context.Sessoes.Remove(sessao);
                    context.SaveChanges();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao deletar sessão");
            }
        }

        public static void DeletarSessaoIdUsuario(int id) {
            try {
                using (Context context = new Context()) {
                    Sessao sessao = context.Sessoes.Where(u => u.Usuario_id == id).FirstOrDefault();
                    context.Sessoes.Remove(sessao);
                    context.SaveChanges();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao deletar sessão");
            }
        }
    }
}