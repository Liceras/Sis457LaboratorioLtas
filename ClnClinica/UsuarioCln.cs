using CadClinica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnClinica
{
    public class UsuarioCln
    {
        public static int insertar(Usuario usuario)
        {
            using (var contexto = new ClinicaEntities())
            {
                contexto.Usuario.Add(usuario);
                contexto.SaveChanges();
                return usuario.id;
            }
        }
        public static int actualizar(Usuario usuario)
        {
            using (var contexto = new ClinicaEntities())
            {
                var existente = contexto.Usuario.Find(usuario.id);
                existente.usuario1 = usuario.usuario1;
                existente.clave = usuario.clave;
                existente.usuarioRegistro = usuario.usuarioRegistro;
                return contexto.SaveChanges();
            }
        }
        public static int eliminar(int id)
        {
            using (var contexto = new ClinicaEntities())
            {
                var existente = contexto.Usuario.Find(id);
                return contexto.SaveChanges();
            }
        }
        public static Usuario validar(string usuario, string clave)
        {
            using (var contexto = new ClinicaEntities())
            {
                return contexto.Usuario
                    .Where(x => x.usuario1 == usuario && x.clave == clave)
                    .FirstOrDefault();
            }
        }

        /*public static Usuario validar(int idEmpleado)
        {
            using (var contexto = new MinervaEntities())
            {
                return contexto.Usuario
                    .Where(x => x.registroActivo.Value && x.idEmpleado == idEmpleado)
                    .FirstOrDefault();
            }
        }*/
    }
}
