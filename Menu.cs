using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePOO
{
    internal class Menu
    {
        public void menu()
        {
            Console.WriteLine("Bienvenido a la Miscelanea Ejercicios C#");
            Console.WriteLine(" ");
            Console.WriteLine("Menu principal");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Seleccione una de la siguientes condicionales: ");
            Console.WriteLine(" 1.si desea hacer Operacion");
            Console.WriteLine(" 2.si desea ver el Condicionales");
            Console.WriteLine(" 3.si desea ver los Ciclos ");
            Console.WriteLine(" 4.si desea ver los Areglos");
            Console.WriteLine(" 99. salir del programa");
            string opcion2 = Console.ReadLine();
            switch (opcion2)
            {
                case "1": 
                    { 
                        Operadores operadores = new Operadores();
                        operadores.Operacion();
                        break; 
                    }
                case "2": 
                    { 
                        Condicionales condicionales = new Condicionales();
                        condicionales.condicionales();
                        break; 
                    }
                case "3": 
                    { 
                        Ciclos ciclos = new Ciclos();
                        ciclos.ciclos();
                        break; 
                    }
                case "99": 
                    { 
                         
                        break; 
                    }

                default: { Console.WriteLine("Opcion invalida"); break; }
            }

        }
        
    }
}
