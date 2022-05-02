using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePOO
{
     class Operadores
    {
        public void Operacion()
        {
            string opcion_operadores;
            Console.WriteLine("Sub menu Operadores");
            Console.WriteLine("---------------------");
            Console.WriteLine("Selecciones una de las siguientes opciones: ");
            Console.WriteLine(" a. si desea Calcular el área de un triángulo.");
            Console.WriteLine(" b. si desea Ingresar dos números por teclado y sumarlos.");
            Console.WriteLine(" c. si desea Ingresar un número y visualizar el número elevado al cuadrado. ");
            Console.WriteLine(" d. si desea Escribir un algoritmo que convierta de euros a dólares.");
            Console.WriteLine(" e. si desea Escribir un algoritmo que pida el lado de un cuadrado y muestre el valor del área y del perímetro..");
            Console.WriteLine(" f. si desea Escribir un algoritmo que determine el área y el volúmen de un cilindro.");
            Console.WriteLine(" g. si desea Realizar un algoritmo que lea el radio de una circunferencia  ");
            Console.WriteLine(" h. si desea Calcular el promedio de tres (3) números ingresados por teclado.");
            Console.WriteLine(" 99. si desea Salir del programa");
            Console.WriteLine("---------------------- ");
            opcion_operadores = Console.ReadLine();
            switch (opcion_operadores)
            {
                case "a": {; break; }
                case "b": {; break; }
                case "c": {; break; }
                case "d": {; break; }
                case "e": {; break; }
                case "f": {; break; }
                case "g": { break; }
                case "h": { break; }
                case "99": { break; }
                default: { Console.WriteLine("Opcion invalida"); break; }
            }
            double AreaTriangulo(double base_t, double altura)
            {
                Console.WriteLine("Calcular area del triangulo");
                Console.WriteLine("Ingrese la base del triangulo: ");
                base_t = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triangulo: ");
                altura = double.Parse(Console.ReadLine());
                double area = (base_t * altura) / 2;
                Console.WriteLine("El area del triangulo es: " + area + " cm²");
                Console.ReadKey();
                return area;
            }


        }

    }
}
