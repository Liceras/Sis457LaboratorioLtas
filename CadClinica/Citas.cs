//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadClinica
{
    using System;
    using System.Collections.Generic;
    
    public partial class Citas
    {
        public int id { get; set; }
        public string urgencia { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> id_Paciente { get; set; }
        public Nullable<int> id_Medico { get; set; }
    
        public virtual Medico Medico { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}