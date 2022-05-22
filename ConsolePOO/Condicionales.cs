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
            int opcion_condicionales;
            do
            {

                try
                {

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
                    opcion_condicionales = int.Parse(Console.ReadLine());
                    switch (opcion_condicionales)
                    {
                        case 1:
                            {
                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.PositivoNegativo();
                                break;
                            }
                        case 2:
                            {

                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.MayorMenor();
                                break;
                            }
                        case 3:
                            {

                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.NumerosEnteros();
                                break;
                            }
                        case 4:
                            {

                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.SumaResta();
                                break;
                            }
                        case 5:
                            {

                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.Cociente();
                                break;
                            }
                        case 6:
                            {

                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.sumaMultiplicacion();
                                break;
                            }
                        case 7:
                            {

                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.AñoBisiesto();
                                break;
                            }
                        case 99:
                            {
                                Environment.Exit(1);
                                break;
                            }

                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\nERROR \nNo ingreso un dato numerico");
                    Console.WriteLine("------------------------------------ ");
                    Console.WriteLine("Ingrese un dato numerico ");
                    Console.WriteLine(" ");

                    opcion_condicionales = 0;
                    Condicionales condicionales = new Condicionales();
                    condicionales.condicionales();
                }
                Console.WriteLine();

            } while (opcion_condicionales == 1 || opcion_condicionales ==2 || opcion_condicionales==3 || opcion_condicionales == 4 || opcion_condicionales == 5 || opcion_condicionales == 6 || opcion_condicionales == 7 || opcion_condicionales == 99 );


            
            
        }
        

        
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
        public void setRespuesta (double respuesta)
        {
            this.respuesta = respuesta; 
        }
       
        public double PositivoNegativo()
        {
            Console.WriteLine("Ingrese numero: ");
            setNum1(int.Parse(Console.ReadLine()));
            if (getNum1() == 0)
            { Console.WriteLine("El numero " + getNum1() + " es neutro"); }
            else if (getNum1() > 0)
            { Console.WriteLine("El numero " + getNum1 + " es positivo."); }
            else
            { Console.WriteLine("el numero " + getNum1 + " es negativo"); }
            Console.ReadKey();
            return getNum1();
        }
        public double MayorMenor()
        {
            Console.WriteLine("Ingrese numero");
            setNum1(float.Parse(Console.ReadLine())); //num1
            Console.WriteLine("Ingrese segundo numero");
            setNum2(float.Parse(Console.ReadLine())); //num2
            if (getNum1() == getNum2())
            {
                Console.WriteLine("estos dos numeros son iguales: ");
            }
            else if (getNum1() > getNum2())
            {
                Console.WriteLine("el numero mayor es: " + getNum1() + " el numero menor es:" + num2);
            }
            else
            {
                Console.WriteLine("el numero mayor es: " + getNum2() + " el numero menor es:" + num1);
            }
            Console.ReadLine();
            return getNum1()+getNum2();


        }
        public double NumerosEnteros()
        {
            Console.WriteLine("Ingrese numero: ");
            setNum1(double.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese segundo numero: ");
            setNum2(double.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese tercer numero:  ");
            setNum3(double.Parse(Console.ReadLine()));
            if (getNum1() >= getNum2() && getNum1() >= getNum3())
            {
                Console.WriteLine("El numero mayor es: " + getNum1());
            }
            else if (getNum2() >= getNum3() && getNum2() >= getNum3())
            {
                Console.WriteLine("El numero mayor es:  " + getNum2());
            }
            else if (getNum3() >= getNum1() && getNum3() >= getNum2())
            {
                Console.WriteLine("El numero mayor es: " + getNum3());
            }
            else if (getNum1() <= getNum2() && getNum1() <= getNum3())
            {
                Console.WriteLine("El numero menor es: " + getNum1());
            }
            else if (getNum2() <= getNum3() && getNum2() <= getNum3())
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
            setNum1(double.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese numero: ");
            setNum2(double.Parse(Console.ReadLine()));
            if (getNum1() >= getNum2())
            {
                setNum3(getNum1() + getNum2()); //num3
                Console.WriteLine("La suma de los numeros es: " + getNum3());
            }
            else if (getNum2() > getNum1())
            {
                setRespuesta(getNum2() + getNum1()); //respuesta
                Console.WriteLine("la resta de los numeros es: " + respuesta);
            }
            Console.ReadKey();
            return getRespuesta();

        }
        public double Cociente()
        {
            
            Console.WriteLine("Ingrese el numero dividendo: ");
            setNum1(double.Parse(Console.ReadLine())); //num1
            Console.WriteLine("Ingrese el numero divisor: ");
            setNum2(double.Parse(Console.ReadLine()));//num2


            if (getNum1() <= 0)
            {
                Console.WriteLine("No se puede hacer la operacion");
            }
            else if (getNum2() <= 0)
            {
                Console.WriteLine("No se puede hacer la operacion");
            }
            else
            {
                Console.WriteLine("El cociente es: " + num1 / num2 );
              
            }
            Console.ReadKey();
            return getNum1() / getNum2();
        }
        public double sumaMultiplicacion()
        {
            
            Console.WriteLine("Ingrese numero: ");
            setNum1(double.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese segundo numero: ");
            setNum2(double.Parse(Console.ReadLine()));
            if (getNum1() < 0 || getNum2() < 0)
            {
                Console.WriteLine("La suma de los numeros es: " + (num1 + num2));
            }
            else if (getNum1() >= 0 && getNum2() >= getNum1())
            {
                Console.WriteLine("La multiplicacion de los numeros es: " + (getNum1() * getNum2());
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
