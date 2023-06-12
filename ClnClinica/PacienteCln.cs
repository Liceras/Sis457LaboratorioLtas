using CadClinica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnClinica
{
    public class PacienteCln
    {
        public static int insertar(Paciente paciente) 
        {
            using (var contexto = new ClinicaEntities())
            {
                contexto.Paciente.Add(paciente);
                contexto.SaveChanges();
                return paciente.id;
            }
        }
        public static int actualizar(Paciente paciente)
        {
            using (var contexto = new ClinicaEntities())
            {
                var existente = contexto.Paciente.Find(paciente.id);
                existente.DNI = paciente.DNI;
                existente.nombres = paciente.nombres;
                existente.apellidos = paciente.apellidos;
                existente.direccion = paciente.direccion;
                existente.telefono = paciente.telefono;
                return contexto.SaveChanges();
            }
        }
        public static int eliminar(int id)
        {
            using (var contexto = new ClinicaEntities())
            {
                var existente = contexto.Paciente.Find(id);
                return contexto.SaveChanges();
            }
        }
    }
}
