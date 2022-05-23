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
            int opcion_operadores;
            do
            {
                try
                {
                    
                    Console.WriteLine("Sub menu Operadores");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Selecciones una de las siguientes opciones: ");
                    Console.WriteLine(" 1. si desea Calcular el área de un triángulo.");
                    Console.WriteLine(" 2. si desea Ingresar dos números por teclado y sumarlos.");
                    Console.WriteLine(" 3. si desea Ingresar un número y visualizar el número elevado al cuadrado. ");
                    Console.WriteLine(" 4. si desea Escribir un algoritmo que convierta de euros a dólares.");
                    Console.WriteLine(" 5. si desea Escribir un algoritmo que pida el lado de un cuadrado y muestre el valor del área y del perímetro..");
                    Console.WriteLine(" 6. si desea Escribir un algoritmo que determine el área y el volúmen de un cilindro.");
                    Console.WriteLine(" 7. si desea Realizar un algoritmo que lea el radio de una circunferencia y escriba la longitud de la \n misma y el área(pi * r) ^ 2 del círculo inscrito. ");
                    Console.WriteLine(" 8. si desea Calcular el promedio de tres (3) números ingresados por teclado.");
                    Console.WriteLine(" 99. si desea Salir del programa");
                    Console.WriteLine("---------------------- ");
                    opcion_operadores = int.Parse(Console.ReadLine());
                    switch (opcion_operadores)
                    {
                        case 1:
                            {
                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.AreaTriangulo();
                                break;
                            }
                        case 2:
                            {
                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.Suma();
                                break;
                            }
                        case 3:
                            {
                                Ejercicios ejercicio = new Ejercicios();
                                ejercicio.Cuadrado();
                                break;
                            }
                        case 4:
                            {

                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.ConversionDolaresEuros();
                                break;
                            }
                        case 5:
                            {
                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.AreayPerimetro();

                                break;
                            }
                        case 6:
                            {
                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.AreayVolumen();
                                break;
                            }
                        case 7:
                            {
                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.Radio();
                                break;
                            }
                        case 8:
                            {
                                Ejercicios ejercicios = new Ejercicios();
                                ejercicios.Promedio();
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
                   
                    opcion_operadores = 0;
                    Operadores operadores = new Operadores();
                    operadores.Operacion();
                    Console.WriteLine();
                }
               
                
            }while(opcion_operadores == 1 || opcion_operadores == 2 || opcion_operadores == 3 || opcion_operadores == 4 || opcion_operadores == 5 || opcion_operadores == 6 || opcion_operadores == 7 || opcion_operadores == 8 || opcion_operadores == 99);
            
           


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
            
            public double AreaTriangulo()
            {
                
                Console.WriteLine("Calcular area del triangulo");
                Console.WriteLine("Ingrese la base del triangulo: ");
                setNum1(double.Parse(Console.ReadLine()));
                Console.WriteLine("Ingrese la altura del triangulo: ");
                setNum2(double.Parse(Console.ReadLine()));
                setRespuesta((getNum1() * getNum2() / 2));
                Console.WriteLine("El area del triangulo es: " + getRespuesta() + " cm²");
                Console.ReadKey();
                return getRespuesta();
            }
            public double Suma()
            {
                Console.WriteLine("Ingrese el primer número : ");
                setNum1(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Ingrese el segundo número : ");
                setNum2(Convert.ToInt32(Console.ReadLine()));
                setRespuesta(getNum1() + getNum2());
                Console.WriteLine("La suma de los numeros es:  " + getRespuesta());
                return getRespuesta();
            }
            public double Cuadrado()
            {
                
                Console.WriteLine("Ingrese un numero");
                setNum1(double.Parse(Console.ReadLine())); 
                setRespuesta(getNum1() * getNum1()) ;
                Console.WriteLine("El numero " + getNum1() + " Elevado al cuadrado es: " + getRespuesta());
                //Console.WriteLine(Math.Pow(numero, 2));

                Console.ReadKey();
                return getRespuesta();
            }
            public double ConversionDolaresEuros()
            {
                
                Console.WriteLine("Ingrese los euros que desea convertir: ");
                setNum1(double.Parse(Console.ReadLine()));
                setRespuesta(getNum1() * 1.06);
                Console.WriteLine("La convercion a dolares es:" + getRespuesta());
                Console.ReadKey();
                return getRespuesta();
            }
            public double AreayPerimetro()
            {
                Console.WriteLine("Ingrese la medida de lado del cuadrado: ");
                setNum1(double.Parse(Console.ReadLine()));
                setNum2(getNum1() * getNum1());
                setRespuesta(4 * getNum1());

                Console.WriteLine("El area del cuadrado es: " + getNum2() + "cm²");
                Console.WriteLine("El perimetro del cuadrado es: " + getRespuesta());
                Console.ReadKey();
                return getRespuesta();
            }
            public double AreayVolumen()
            {
                Console.WriteLine("Ingrese la perimetro: ");
                setNum1(double.Parse(Console.ReadLine()));//num1
                Console.WriteLine("Ingrese la altura");
                setNum2(double.Parse(Console.ReadLine()));//num2
                Console.WriteLine("Ingrese radio");
                setNum3(double.Parse(Console.ReadLine()));//num3
                Console.WriteLine("el area del cilindro es: " + (2 * Math.PI * getNum1() * getNum2()));
                Console.WriteLine("el volumen del cilindro es:" + (Math.PI * getNum3() * getNum3() * getNum2()));
                Console.ReadKey();
                return getNum3();
            }
            public double Radio()
            {
                Console.WriteLine("Ingrese el radio de la circunferencia: ");
                setNum1(double.Parse(Console.ReadLine()));
                setNum2(getNum1() * 2 * System.Math.PI);
                setNum3(System.Math.PI * getNum1() * getNum1());
                Console.WriteLine("El  area del circulo es: " + getNum2() );
                Console.WriteLine("La longitud de la circunferencia es: " + getNum3());
                Console.ReadKey();
                return getNum1();
            }
            public double Promedio()
            {
                Console.WriteLine("Ingrese primer valor: ");
                setNum1(double.Parse(Console.ReadLine()));
                Console.WriteLine("Ingrese segundo valor: ");
                setNum2(double.Parse(Console.ReadLine()));
                Console.WriteLine("Ingrese tercer valor: ");
                setNum3(double.Parse(Console.ReadLine()));
                setRespuesta((getNum1() + num2 + num3) / 3);
                Console.WriteLine("El promedio de los tres valores es de: " +getRespuesta());
                
                Console.ReadKey();
                return getRespuesta();
            }

        }
    }
}
