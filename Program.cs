using System;
using aulaPooHeranca.classes;

namespace aulaPooHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
           
            pf.cpf = "111.222.333-44";

            pf.nome = "Marcelo";

            Console.WriteLine( pf.darBoasVindas(pf.nome));

            Console.WriteLine (pf.ValidarCpf(pf.cpf));

        }
    }
}