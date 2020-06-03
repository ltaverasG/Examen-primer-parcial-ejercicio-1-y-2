using System;
using System.Security.Cryptography;
/*Pedir al usuario el precio de un producto y la forma de pagar
* (efectivo o tarjeta) si la forma de pago es mediante tarjeta, 
* pedir el numero de tarjeta (12 digitos). Ojo, validar que el valor ingresado en el sea positivo. */

namespace EXAMEN_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {// Variables 
            int precio = 0;
            int efectivo = 0;
            int tarjeta ;
            int opcion = 0;
            int T;


            //dato del precio del producto 
            Console.WriteLine("INGRESE EL PRECIO DEL PRODUCTO");
            precio = Convert.ToInt32(Console.ReadLine());

            //forma de pago 
            Console.WriteLine("INGRESE FORMA DE PAGO");
            Console.WriteLine("1- efectivo 2- tarjeta");
            opcion = Convert.ToInt32(Console.ReadLine());
            // condiciones 
            //efectivo 
            if (opcion == 1)
            {
                Console.WriteLine("Ingrese el total a pagar de: " + precio);
                int I = Convert.ToInt32(Console.ReadLine());
                if (I != precio)
                {
                    Console.WriteLine(" ERROR INTENTE DE NUEVO ");
                }
            }
            //tarjeta
            if (opcion == 2)
            {
                Console.WriteLine("INGRESE EL NUMERO DE LA TARJETA");
               // bucle para que ingrese los 12 digitos y la condicion para evitar que halla un numero negativo.
                while (efectivo <12)
                {
                    efectivo++;
                    tarjeta = Convert.ToInt32(Console.ReadLine());
                    if (tarjeta < 0)
                    {
                        Console.WriteLine("ERROR INTENTE DE NUEVO ");
                    }
                }
               
                    
            }


        }

    }
 } 
