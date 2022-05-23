using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePOO
{
    internal class main
    {
        
        public static void Main(string[] args)
        {
            
            
                try
                {
                    Menu menu = new Menu();
                    menu.menu();
                Console.WriteLine();

                }
                catch (FormatException ex)
                {


                    Console.WriteLine("\nERROR \nNo ingreso un dato numerico");
                    Console.WriteLine("------------------------------------ ");
                    Console.WriteLine("Ingrese un dato numerico ");
                    Console.WriteLine(" ");

                        Menu menu = new Menu();
                        menu.menu();

                }
                Console.ReadKey();
            
           
            
        }
    }
    
}
