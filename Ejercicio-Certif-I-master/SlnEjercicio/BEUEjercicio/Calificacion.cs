//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEUEjercicio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calificacion
    {
        public int idcalificacion { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string unidad { get; set; }
        public Nullable<int> idmatricula { get; set; }
    
        public virtual Matricula Matricula { get; set; }
    }
}
