using System;

namespace Fixaçao6
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Clear();
        
        string[] nomes = new string[10];
        string[] pessoa = new string[1];
        int contador = 0;
        string busca ;
       

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("");
                Console.WriteLine("Digite o nome: ");
                Console.WriteLine("");
                Console.ResetColor();

                nomes[i] = Console.ReadLine();
                Console.WriteLine("");
            }

                Console.WriteLine("");
                Console.WriteLine("Deseja inserir mais um nome ?");
                Console.WriteLine("");
                string resposta = Console.ReadLine();

                if (resposta == "s")
                {
                    Console.WriteLine("Insira o nome: ");
                    Console.WriteLine("");
                    pessoa[contador] = Console.ReadLine();
                    Console.WriteLine("");
                    
                    contador++;
                } 
                else if(resposta == "n"){
                    Console.WriteLine("");
                    Console.WriteLine("Sistema Finalizado!");
                }

                    foreach (string nome in nomes)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(nome);
                        Console.ResetColor();
                    }


                 Console.WriteLine($"Deseja entrar no sistema de busca? ");
                 string escolha = Console.ReadLine();

                    if (escolha == "s")
                    {
                        Console.WriteLine($"Iniciando o sistema de busca:");
                        Console.WriteLine($"Digite o nome procurado: ");
                        Console.WriteLine("");
                        busca = Console.ReadLine();
                                
                           
                      
                    } 
                    else if (escolha == "n")
                    {
                        Console.WriteLine($"Sistema Finalizado!");
                    }
               
                
                
        }
    }
}