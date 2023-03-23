using Repository;
using System.Collections.Generic;
using System.Linq;

namespace Models {
    public class Usuario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario(int id, string nome, string email, string senha) {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public override string ToString() {
            return $"Id: {Id} | Nome: {Nome} | Email: {Email} | Senha: {Senha}";
        }

        public static void CadastrarUsuario(Usuario usuario) {
            try {
                using (Context context = new Context()) {
                    context.Usuarios.Add(usuario);
                    context.SaveChanges();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao cadastrar usuário");
            }
        }

        public static List<Usuario> BuscarUsuario() {
            try {
                using (Context context = new Context()) {
                    return (from usuario in context.Usuarios select usuario).ToList();   
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao buscar usuário");
            }
        }

        public static List<Usuario> BuscarUsuarioEmailSenha(string email, string senha) {
            try {
                using (Context context = new Context()) {
                    return context.Usuarios.Where(x => x.Email == email && x.Senha == senha).ToList();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao buscar usuário");
            }
        }

        public static void AtualizarUsuario(Usuario usuario) {
            try {
                using (Context context = new Context()) {
                    context.Usuarios.Update(usuario);
                    context.SaveChanges();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao atualizar usuário");
            }
        }

        public static void DeletarUsuario(int id) {
            try {
                using (Context context = new Context()) {
                    context.Usuarios.Remove(context.Usuarios.Find(id));
                    context.SaveChanges();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao deletar usuário");
            }
        }
    }
}