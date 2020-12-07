using System;
using aulaPooHeranca.classes;

namespace aulaPooHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
           
            pf.cpf = "524.101.418-70";

            pf.nome = "Giovanni";

            Pessoajuridica pj = new Pessoajuridica();
            
            pj.cnpj= "32.654.368/0001-60";
           
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( pf.darBoasVindas(pf.nome));
            
            Console.WriteLine(pj.IsCnpj (pj.cnpj));

            Console.WriteLine (pf.IsCpf (pf.cpf));
            Console.ResetColor();
        }
    }
}