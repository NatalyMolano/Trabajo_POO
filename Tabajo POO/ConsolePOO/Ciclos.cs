using System;
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
            int opcion_ciclos;
            do
            {
                try
                {

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
                    Console.WriteLine(" 99. si desea Salir del programa");
                    Console.WriteLine("---------------------- ");
                    opcion_ciclos = int.Parse(Console.ReadLine());
                    switch (opcion_ciclos)
                    {
                        case 1: { Ejercicios ejercicios = new Ejercicios(); ejercicios.Multiplos(); break; }
                        case 2: { Ejercicios ejercicios = new Ejercicios(); ejercicios.Impares(); break; }
                        case 3: { Ejercicios ejercicios = new Ejercicios(); ejercicios.Pares(); break; }
                        case 4: { Ejercicios ejercicios = new Ejercicios(); ejercicios.Cuadrados(); break; }
                        case 5: { Ejercicios ejercicios = new Ejercicios(); ejercicios.SumaCuadrados(); break; }
                        case 6: { Ejercicios ejercicios = new Ejercicios(); ejercicios.comprendidos(); break; }
                        case 7: { Ejercicios ejercicios = new Ejercicios(); ejercicios.SumavariosN(); break; }
                        case 99: { Environment.Exit(1); break; }

                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\nERROR \nNo ingreso un dato numerico");
                    Console.WriteLine("------------------------------------ ");
                    Console.WriteLine("Ingrese un dato numerico ");
                    Console.WriteLine(" ");

                    opcion_ciclos = 0;
                    Ciclos ciclos = new Ciclos();
                    ciclos.ciclos();
                }

            } while (opcion_ciclos==1 || opcion_ciclos==2 || opcion_ciclos==3 || opcion_ciclos == 4 || opcion_ciclos == 5 || opcion_ciclos == 6 || opcion_ciclos == 7 || opcion_ciclos == 99 );
            


        }
        class Ejercicios
        {
            private double num1 = 0.0;
            private double num2 = 0.0;
            private double num3 = 0.0;
            private double respuesta = 0.0;
            public double getNum1()
            {
                return this.num1;
            }
            public void setNum1(double num1)
            {
                this.num1 = num1;
            }
            public double getNum2()
            {
                return this.num2;
            }
            public void setNum2(double num2)
            {
                this.num2 = num2;
            }
            public double getNum3()
            {
                return this.num3;
            }
            public void setNum3(double num3)
            {
                this.num3 = num3;
            }
            public double getRespuesta()
            {
                return this.respuesta;
            }
            public void setRespuesta(double respuesta)
            {
                this.respuesta = respuesta;
            }
            public double Multiplos()
            {
                for (setNum1(1) ; getNum1() < 100; num1++)//num1
                {
                    if (getNum1() % 3 == 0)
                    {
                        Console.Write("{0}|", getNum1());
                    }
                }
                Console.ReadKey();
                return getNum1();
            }
            public double Impares()
            {
                for (setNum1(1); getNum1() < 100; num1 += 2)
                {
                    Console.Write("{0}|", getNum1());

                }
                Console.ReadKey();
                return getNum1();
            }
            public double Pares()
            {
                for (setNum1(1); getNum1() < 100; num1++)
                {
                    if (getNum1() % 2 == 0)
                    {
                        Console.Write("{0}|", getNum1());
                    }
                }
                Console.ReadKey();
                return getNum1();
            }
            public double Cuadrados()
            {
                for (setNum1(1); getNum1() < 31; num1++)
                {
                    Console.Write("| " + getNum1() * getNum1());
                    Console.ReadKey();
                }
                return getNum1();


            }
            public double SumaCuadrados()
            {
                
                for (setNum1(1); getNum1() <= 100; num1++)//num1
                {
                    Console.WriteLine("Numero " + getNum1());
                    setRespuesta(getRespuesta() + getNum1() * getNum1());
                    Console.WriteLine("El cuadrado es: " + Math.Pow(getNum1(), 2));
                }
                Console.WriteLine("\nLa suma total de los cuadrados es: " + getRespuesta());
                Console.ReadKey();
                return getRespuesta();
            }
            public double comprendidos()
            {
                
                Console.WriteLine("Ingrese numero menor: ");
                setNum1(double.Parse(Console.ReadLine()));
                Console.WriteLine("Ingrese numero mayor: ");
                setNum2(double.Parse(Console.ReadLine())) ;
                Console.WriteLine("Numeros comprendidos");
                for (setRespuesta(1); getRespuesta() <= getNum2(); respuesta++)
                {
                    Console.Write("| " + getRespuesta());
                }
                return getRespuesta();
            }
            public double SumavariosN()
            {
                setNum1(0); //num1
                setNum2(0);//num2
                Console.WriteLine("¿cuantos numero quiere sumar?");
                setNum3(double.Parse(Console.ReadLine()));//num3
                for (setRespuesta(1); getRespuesta() <= getNum3(); respuesta++)//respuesta
                {
                    setNum1(Convert.ToDouble(Console.ReadLine()));
                    setNum2(getNum2() + getNum1());
                }
                Console.WriteLine("La suma es: " + getNum2());
                return getNum2();
            }

        }
    }
}
