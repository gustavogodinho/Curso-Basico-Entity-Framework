using System;
using System.Linq;

namespace Entity_CursoBasico
{
    public class Entity
    {
        public static string GravaAluno(string nome)
        {
            try
            {
                using (var ctx = new EscolaEntity())
                {
                    ctx.Aluno.Add(new Aluno() { AlunoNome = nome });
                    ctx.SaveChanges();
                }
                return "Aluno: " + nome + " adicionado com sucesso!";
            }
            catch (Exception)
            {
                return "Deu erro ta ligado.";
            }
        }

        public static string GravaPadrao(string padraoNome, string descricao)
        {
            try
            {
                using (var ctx = new EscolaEntity())
                {
                    ctx.Padrao.Add(new Padrao() { PadraoNome = padraoNome, Descricao = descricao });
                    ctx.SaveChanges();
                }
                return "Padrao: " + padraoNome + " adicionado com sucesso!";
            }
            catch (Exception ex)
            {
                return "Deu erro ta ligado. " + ex.Message;
            }

        }

        public static Aluno ObterAluno(string nome)
        {

            try
            {
                using (var ctx = new EscolaEntity())
                {
                    var listaAluno = ctx.Aluno.ToList();

                    Aluno aluno = ctx.Aluno
                                   .Where(s => s.AlunoNome.Contains(nome))
                                   .FirstOrDefault();
                    if (aluno == null)
                    {
                        throw new Exception("procure o aluno correto, Rodrigo Maia");
                    }
                    return aluno;
                }
            }
            catch
            {
                throw;
            }

        }


    }
}
