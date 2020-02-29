using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaEntidade_OO.Entidades;

namespace ListaEntidade_OO

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXXXXXXXX   Lista   XXXXXXXXXX");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");

            List<Nomes>ListaNomes= new List<Nomes>();

          
            Console.WriteLine("Cadastrar quantos nomes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; n > i; i++)
            {
                
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------------------------------");



                Console.Write("Nome:");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());

                ListaNomes.Add(new Nomes(nome, idade));
                

                //ListaNomes.Add(new Nomes(nome, idade));


                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
                Console.WriteLine();

                //Console.WriteLine(No);
                //Console.WriteLine(nome.Idade);
                //ListaNomes.Add(new Nomes(nome,idade)); 
            }


            
                foreach ( Nomes  nome in ListaNomes)
                {
                    Console.WriteLine(nome.Nome);
                    Console.WriteLine(nome.Idade);



                    
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine();
                    Console.WriteLine();


                   

                
                }

                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
                Console.WriteLine();
            

            Console.ReadKey();

        }
    }
}
