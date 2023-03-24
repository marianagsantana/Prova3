using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Models {
    public class Perfil {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public int Usuario_id { get; set; }
        public bool Admnistrador { get; set; }
        
        public Perfil(int id, int usuario_id, bool admnistrador) {
            this.Id = id;
            this.Usuario_id = usuario_id;
            this.Admnistrador = admnistrador;
        }

        public override string ToString() {
            return $"Id: {Id} | Administrador: {Admnistrador} | Usuario: {Usuario_id}";
        }

        public static void CadastrarPerfil(Perfil perfil) {
            try {
                using (Context context = new Context()) {
                    context.Perfis.Add(perfil);
                    context.SaveChanges();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao cadastrar perfil");
            }
        }

        public static List<Perfil> BuscarPerfil() {
            try {
                using (Context context = new Context()) {
                    return context.Perfis.ToList();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao buscar perfil");
            }
        }

        public static void AtualizarPerfil(Perfil perfil) {
            try {
                using (Context context = new Context()) {
                    context.Perfis.Update(perfil);
                    context.SaveChanges();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao atualizar perfil");
            }
        }

        public static void DeletarPerfil(int id) {
            try {
                using (Context context = new Context()) {
                    context.Perfis.Remove(context.Perfis.Find(id));
                    context.SaveChanges();
                }
            } catch (System.Exception) {
                throw new System.Exception("Erro ao deletar perfil");
            }
        }

    }
}