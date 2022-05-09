﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePOO
{
    internal class Ciclos
    {
        public void ciclos()
        {
            string opcion_ciclos;
            Console.WriteLine("Sub menu Ciclos");
            Console.WriteLine("---------------------");
            Console.WriteLine("Selecciones una de las siguientes opciones: ");
            Console.WriteLine(" 1. si desea Imprimir todos los múltiplos de 3 que hay entre 1 y 100.");
            Console.WriteLine(" 2. si desea Imprimir los números impares entre 0 y 100.");
            Console.WriteLine(" 3. si desea Imprimir los números pares del 1 al 100.");
            Console.WriteLine(" 4. si desea ver en pantalla los cuadrados de los números del 1 al 30.");
            Console.WriteLine(" 5. si desea Escribir un programa que sume los cuadrados de los cien primeros números naturales,");
            Console.WriteLine(" mostrando el resultado en pantalla.");
            Console.WriteLine(" 6. si desea Dar dos números naturales, el primero menor que el segundo,mostrar todos los ");
            Console.WriteLine(" comprendidos entre ellos en secuencia ascendente.");
            Console.WriteLine(" 7. Sumar todos los números que se digitan por teclado mientras no sea cero.");
            Console.WriteLine(" 8. Si desea volver al menu principal");
            Console.WriteLine(" 99. si desea Salir del programa");
            Console.WriteLine("---------------------- ");
            opcion_ciclos = Console.ReadLine();
            switch (opcion_ciclos)
            {
                case "1": { Ejercicios ejercicios = new Ejercicios(); ejercicios.Multiplos(); break; }
                case "2": { Ejercicios ejercicios = new Ejercicios(); ejercicios.Impares(); break; }
                case "3": { Ejercicios ejercicios = new Ejercicios(); ejercicios.Pares(); break; }
                case "4": { Ejercicios ejercicios = new Ejercicios(); ejercicios.Cuadrados(); break; }
                case "5": { Ejercicios ejercicios = new Ejercicios(); ejercicios.SumaCuadrados(); break; }
                case "6": { Ejercicios ejercicios = new Ejercicios(); ejercicios.comprendidos(); break; }
                case "7 ": { Ejercicios ejercicios = new Ejercicios(); ejercicios.SumavariosN(); break; }
                case "8": { main main = new main(); main.Main(); break; }
                case "99": {  break; }
                default: { Console.WriteLine("Opcion invalida"); break; }
            }




        }
        class Ejercicios
        {
            private double num1 = 0.0;
            private double num2 = 0.0;
            private double num3 = 0.0;
            private double respuesta = 0.0;
            public double Multiplos()
            {
                for (num1 = 1; num1 < 100; num1++)//num1
                {
                    if (num1 % 3 == 0)
                    {
                        Console.Write("{0}|", num1);
                    }
                }
                Console.ReadKey();
                return num1;
            }
            public double Impares()
            {
                for (num1 = 1; num1 < 100; num1 += 2)
                {
                    Console.Write("{0}|", num1);

                }
                Console.ReadKey();
                return num1;
            }
            public double Pares()
            {
                for (num1 = 1; num1 < 100; num1++)
                {
                    if (num1 % 2 == 0)
                    {
                        Console.Write("{0}|", num1);
                    }
                }
                Console.ReadKey();
                return num1;
            }
            public double Cuadrados()
            {
                for (num1 = 1; num1 < 31; num1++)
                {
                    Console.Write("| " + num1 * num1);
                    Console.ReadKey();
                }
                return num1;


            }
            public double SumaCuadrados()
            {
                
                for (num1 = 1; num1 <= 100; num1++)//num1
                {
                    Console.WriteLine("Numero " + num1);
                    respuesta = respuesta + num1 * num1;
                    Console.WriteLine("El cuadrado es: " + Math.Pow(num1, 2));
                }
                Console.WriteLine("\nLa suma total de los cuadrados es: " + respuesta);
                Console.ReadKey();
                return respuesta;
            }
            public double comprendidos()
            {
                
                Console.WriteLine("Ingrese numero menor: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese numero mayor: ");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Numeros comprendidos");
                for (respuesta = num1; respuesta <= num2; respuesta++)
                {
                    Console.Write("| " + respuesta);
                }
                return respuesta;
            }
            public double SumavariosN()
            {
                num1 = 0;//num1
                num2 = 0;//num2
                Console.WriteLine("¿cuantos numero quiere sumar?");
                num3 = double.Parse(Console.ReadLine());//num3
                for (respuesta = 1; respuesta <= num3; respuesta++)//respuesta
                {
                    num1 = Convert.ToDouble(Console.ReadLine());
                    num2 = num2 + num1;
                }
                Console.WriteLine("La suma es: " + num2);
                return num2;
            }

        }
    }
}
