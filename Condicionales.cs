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
            Console.WriteLine(" a. si desea escribir un algoritmo para saber si el numero ingresado por teclado es positivo o negativo.");
            Console.WriteLine(" b. si desea escribir un algoritmo que reciba dos numeros por teclao y diga cual es el mayor y cual es el menor.");
            Console.WriteLine(" c. si desea Ingrese  tres números enteros positivos para que calcule e imprima en pantalla el menor y el mayor de ellos");
            Console.WriteLine(" d. si desea Dar dos números A y B, sumarlos si A es menor que B o sino restarlos.");
            Console.WriteLine(" e. si desea Dar dos números A y B encontrar el cociente entre A y B.");
            Console.WriteLine(" f. si desea Dar dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.");
            Console.WriteLine(" g. si desea Escribir un algoritmo que determine si un año es bisiesto o no.");
            Console.WriteLine(" 99. si desea Salir del programa");
            Console.WriteLine("---------------------- ");
            opcion_condicionales = Console.ReadLine();
            
        }
    }
}
