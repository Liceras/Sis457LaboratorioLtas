using CadClinica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnClinica
{
    public class CitaCln
    {
        public static int insertar(Citas citas)
        {
            using (var contexto = new ClinicaEntities())
            {
                contexto.Citas.Add(citas);
                contexto.SaveChanges();
                return citas.id;
            }
        }
        public static int actualizar(Citas citas)
        {
            using (var contexto = new ClinicaEntities())
            {
                var existente = contexto.Citas.Find(citas.id);
                existente.urgencia = citas.urgencia;
                return contexto.SaveChanges();
            }
        }
        public static int eliminar(int id)
        {
            using (var contexto = new ClinicaEntities())
            {
                var existente = contexto.Citas.Find(id);
                return contexto.SaveChanges();
            }
        }
    }
}
