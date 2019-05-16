﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EscolaEntity : DbContext
    {
        public EscolaEntity()
            : base("name=EscolaEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aluno> Aluno { get; set; }
        public virtual DbSet<AlunoCurso> AlunoCurso { get; set; }
        public virtual DbSet<AlunoEndereco> AlunoEndereco { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Padrao> Padrao { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<view_AlunoCurso> view_AlunoCurso { get; set; }
    
        public virtual ObjectResult<GetCursosPorAlunoId_Result> GetCursosPorAlunoId(Nullable<int> alunoId)
        {
            var alunoIdParameter = alunoId.HasValue ?
                new ObjectParameter("AlunoId", alunoId) :
                new ObjectParameter("AlunoId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCursosPorAlunoId_Result>("GetCursosPorAlunoId", alunoIdParameter);
        }
    
        public virtual int sp_AtualizarAluno(Nullable<int> alunoId, Nullable<int> padraoId, string alunoNome)
        {
            var alunoIdParameter = alunoId.HasValue ?
                new ObjectParameter("AlunoId", alunoId) :
                new ObjectParameter("AlunoId", typeof(int));
    
            var padraoIdParameter = padraoId.HasValue ?
                new ObjectParameter("PadraoId", padraoId) :
                new ObjectParameter("PadraoId", typeof(int));
    
            var alunoNomeParameter = alunoNome != null ?
                new ObjectParameter("AlunoNome", alunoNome) :
                new ObjectParameter("AlunoNome", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AtualizarAluno", alunoIdParameter, padraoIdParameter, alunoNomeParameter);
        }
    
        public virtual int sp_DeletarAluno(Nullable<int> alunoId)
        {
            var alunoIdParameter = alunoId.HasValue ?
                new ObjectParameter("AlunoId", alunoId) :
                new ObjectParameter("AlunoId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeletarAluno", alunoIdParameter);
        }
    
        public virtual int sp_InserirAlunoInfo(Nullable<int> padraoId, string alunoNome)
        {
            var padraoIdParameter = padraoId.HasValue ?
                new ObjectParameter("PadraoId", padraoId) :
                new ObjectParameter("PadraoId", typeof(int));
    
            var alunoNomeParameter = alunoNome != null ?
                new ObjectParameter("AlunoNome", alunoNome) :
                new ObjectParameter("AlunoNome", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InserirAlunoInfo", padraoIdParameter, alunoNomeParameter);
        }
    }
}
