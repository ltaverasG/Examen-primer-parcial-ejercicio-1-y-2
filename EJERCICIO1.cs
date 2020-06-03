using System;
/*Crear un programa que pida el nombre de un dia de la semana e identifique si es fin de semana o no. En caso de error, indicarlo */
namespace EXAMEN_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {// variables 
            int Dia = 0;
            int lunes = 1;
            int martes = 2;
            int miercoles = 3;
            int jueves = 4;
            int viernes = 5;
            int sabado = 6;
            int domingo = 7;

            // ponemos encabezado 
            Console.WriteLine("Ingrese un dia de la semana del 1 al 7 ");

            //ingresamos dato en la variable dia
            Dia = Convert.ToInt32(Console.ReadLine());

            // condiciones.

            //Error 
            if (Dia > 7)
            {
                Console.WriteLine("ERROR EXCEDIO EL LIMITE...");
            }

            //Fin de semana
            if (Dia > 5)
            {
                if (Dia == 6)
                {
                    Console.WriteLine("El dia es sabado y cae en el fin de semana");
                }
                else
                {
                    Console.WriteLine("El dia es Domingo y cae en el fin de semana");
                }
            }
            // dia de semana 
            if (Dia < 6)
            {
                if (Dia == 1)
                {
                    Console.WriteLine(" El dia es Lunes ");
                }

                if (Dia == 2)
                {
                    Console.WriteLine(" El dia es Martes ");
                }

                if (Dia == 3)
                {
                    Console.WriteLine(" El dia es Miercoles ");
                }

                if (Dia == 4)
                {
                    Console.WriteLine(" El dia es Jueves ");
                }

                if (Dia == 5)
                {
                    Console.WriteLine(" El dia es Viernes ");
                }







            }
        }
    }
}
