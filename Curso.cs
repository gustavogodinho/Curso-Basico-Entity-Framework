//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_CursoBasico
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curso
    {
        public int CursoID { get; set; }
        public string CursoNome { get; set; }
        public System.Data.Entity.Spatial.DbGeography CursoLocalizacao { get; set; }
        public Nullable<int> ProfessorID { get; set; }
    
        public virtual Professor Professor { get; set; }
    }
}