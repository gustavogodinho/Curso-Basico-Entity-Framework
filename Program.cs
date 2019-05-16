using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_CursoBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite:");
            Console.WriteLine(" 1 para cadastrar um Aluno");
            Console.WriteLine(" ");
            Console.WriteLine(" 2 para cadastrar um Padrão");
            Console.WriteLine(" ");
            Console.WriteLine(" 3 para cadastrar um Padrão");
            Console.WriteLine(" ");
            string cadastro = Console.ReadLine();

            if (cadastro == "1")
            {
                Console.WriteLine("Digite o nome");
                string nombre = Console.ReadLine();
                var teste = Entity.GravaAluno(nombre);
                Console.WriteLine(teste);
            }
            else if (cadastro == "2")
            {
                Console.WriteLine("Digite o nome");
                string padraoNome = Console.ReadLine();
                Console.WriteLine("Digite a descrição");
                string descricao = Console.ReadLine();
                var padrao = Entity.GravaPadrao(padraoNome, descricao);
                Console.WriteLine(padrao);
            }
            else if (cadastro == "3")
            {
                Console.WriteLine("Digite o nome");
                string buscaNome = Console.ReadLine();

                try
                {
                    var aluno = Entity.ObterAluno(buscaNome);

                    if (aluno != null)
                    {
                        Console.WriteLine(aluno.AlunoNome);
                    }
                    else
                    {
                        Console.WriteLine($"O Aluno {buscaNome} não foi encontrado!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Voce nao sabe procura nem um aluno: {ex.Message} ");
                }
            }
        }
    }
}
