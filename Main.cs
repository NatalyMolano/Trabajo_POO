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
            
            do

            {
                try
                {
                        Menu menu = new Menu();
                    menu.menu();

                }catch (FormatException ex)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Lo que digito no es valido");
                    Environment.Exit(1);
                }
                 
               
            } while(true );

            {
               
            }
            
            
        }
    }
    
}
