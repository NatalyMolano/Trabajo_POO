using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePOO
{
    internal class Condicionales
    {
        public void condicionales()
        {
            
            string opcion_condicionales;
            Console.WriteLine("Sub menu Condicionales");
            Console.WriteLine("---------------------");
            Console.WriteLine("Selecciones una de las siguientes opciones: ");
            Console.WriteLine(" 1. si desea escribir un algoritmo para saber si el numero ingresado por teclado es positivo o negativo.");
            Console.WriteLine(" 2. si desea escribir un algoritmo que reciba dos numeros por teclao y diga cual es el mayor y cual es el menor.");
            Console.WriteLine(" 3. si desea Ingrese  tres números enteros positivos para que calcule e imprima en pantalla el menor y el mayor de ellos");
            Console.WriteLine(" 4. si desea Dar dos números A y B, sumarlos si A es menor que B o sino restarlos.");
            Console.WriteLine(" 5. si desea Dar dos números A y B encontrar el cociente entre A y B.");
            Console.WriteLine(" 6. si desea Dar dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.");
            Console.WriteLine(" 7. si desea Escribir un algoritmo que determine si un año es bisiesto o no.");
            Console.WriteLine(" 99. si desea Salir del programa");
            Console.WriteLine("---------------------- ");
            opcion_condicionales = Console.ReadLine();
            switch (opcion_condicionales)
            {
                case "1": 
                    { 
                        Ejercicios ejercicios = new Ejercicios();
                        ejercicios.PositivoNegativo(); 
                        break; 
                    }
                case "2": 
                    {

                        Ejercicios ejercicios = new Ejercicios();
                        ejercicios.MayorMenor();
                        break; 
                    }
                case "3": 
                    {

                        Ejercicios ejercicios = new Ejercicios();
                        ejercicios.NumerosEnteros(); 
                        break; 
                    }
                case "4": 
                    {

                        Ejercicios ejercicios = new Ejercicios();
                        ejercicios.SumaResta(); 
                        break; 
                    }
                case "5": 
                    {

                        Ejercicios ejercicios = new Ejercicios();
                        ejercicios.Cociente(); 
                        break; 
                    }
                case "6": 
                    {

                        Ejercicios ejercicios = new Ejercicios();
                        ejercicios.sumaMultiplicacion();
                        break; 
                    }
                case "7": 
                    {

                        Ejercicios ejercicios = new Ejercicios();
                        ejercicios.AñoBisiesto();
                        break; 
                    }
                case "99": 
                    {
                        
                        break; 
                    }
                default:
                    { Console.WriteLine("Opcion invalida"); break; }
                    Console.ReadKey();
            }
            
        }
        

        
    }
    class Ejercicios
    { 

        double num1 = 0.0;
        double num2 = 0.0;  
        double num3 = 0.0;  
        double respuesta = 0.0;
        public double PositivoNegativo()
        {
            Console.WriteLine("Ingrese numero: ");
            num1 = int.Parse(Console.ReadLine());//num1
            if (num1 == 0)
            { Console.WriteLine("El numero " + num1 + " es neutro"); }
            else if (num1 > 0)
            { Console.WriteLine("El numero " + num1 + " es positivo."); }
            else
            { Console.WriteLine("el numero " + num1 + " es negativo"); }
            Console.ReadKey();
            return num1;
        }
        public double MayorMenor()
        {
            Console.WriteLine("Ingrese numero");
            num1 = float.Parse(Console.ReadLine());//num1
            Console.WriteLine("Ingrese segundo numero");
            num2 = float.Parse(Console.ReadLine());//num2
            if (num1 == num2)
            {
                Console.WriteLine("estos dos numeros son iguales: ");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("el numero mayor es: " + num1 + " el numero menor es:" + num2);
            }
            else
            {
                Console.WriteLine("el numero mayor es: " + num2 + " el numero menor es:" + num1);
            }
            Console.ReadLine();
            return num1+num2;


        }
        public double NumerosEnteros()
        {
            Console.WriteLine("Ingrese numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer numero:  ");
            num3 = double.Parse(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("El numero mayor es: " + num1);
            }
            else if (num2 >= num3 && num2 >= num3)
            {
                Console.WriteLine("El numero mayor es:  " + num2);
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine("El numero mayor es: " + num3);
            }
            else if (num1 <= num2 && num1 <= num3)
            {
                Console.WriteLine("El numero menor es: " + num1);
            }
            else if (num2 <= num3 && num2 <= num3)
            {
                Console.WriteLine("El numero menor es:  " + num2);
            }
            else if (num3 <= num1 && num3 <= num2)
            {
                Console.WriteLine("El numero menor es: " + num3);
            }
            
            Console.ReadKey();
            return num1;
        }
        public double SumaResta()
        {
            
            Console.WriteLine("Ingresa numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero: ");
            num2 = double.Parse(Console.ReadLine());
            if (num1 >= num2)
            {
                num3 = num1 + num2;//num3
                Console.WriteLine("La suma de los numeros es: " + num3);
            }
            else if (num2 > num1)
            {
                respuesta = num2 + num1;//respuesta
                Console.WriteLine("la resta de los numeros es: " + respuesta);
            }
            Console.ReadKey();
            return respuesta;

        }
        public double Cociente()
        {
            
            Console.WriteLine("Ingrese el numero dividendo: ");
            num1 = double.Parse(Console.ReadLine());//num1
            Console.WriteLine("Ingrese el numero divisor: ");
            num2 = double.Parse(Console.ReadLine());//num2


            if (num1 <= 0)
            {
                Console.WriteLine("No se puede hacer la operacion");
            }
            else if (num2 <= 0)
            {
                Console.WriteLine("No se puede hacer la operacion");
            }
            else
            {
                Console.WriteLine("El cociente es: " + num1 / num2 );
              
            }
            Console.ReadKey();
            return num1 / num2;
        }
        public double sumaMultiplicacion()
        {
            
            Console.WriteLine("Ingrese numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero: ");
            num2 = double.Parse(Console.ReadLine());
            if (num1 < 0 || num2 < 0)
            {
                Console.WriteLine("La suma de los numeros es: " + (num1 + num2));
            }
            else if (num1 >= 0 && num2 >= num1)
            {
                Console.WriteLine("La multiplicacion de los numeros es: " + (num1 * num2));
            }
            Console.ReadKey();
            return num1;


        }
        static bool Bisiesto(double año)
        {
            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0)) return true;
            return false;
        }
        public double AñoBisiesto()
        {
            Console.WriteLine("Ingrese año: ");
            num1 = double.Parse(Console.ReadLine());//num1
            if (Bisiesto(num1) == true)
            {
                Console.WriteLine("El año {0} es bisiesto ", num1);
            }
            else
            {
                Console.WriteLine("El año {0} NO es bisiesto", num1);
            }
            Console.ReadKey();
            return num1;
        }
        
    }
    
}
