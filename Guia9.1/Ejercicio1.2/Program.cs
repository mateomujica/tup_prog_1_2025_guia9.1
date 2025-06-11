using System;

namespace Ejercicio1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vectores
            string[] nombres;
            nombres = new string[100];


            int[] libreta;
            libreta = new int[100];


            double[] notas;
            notas = new double[100];
            #endregion

            #region Variables
            int contador = 0;
            double promedio = 0;
            double total = 0;
            double acumulado = 0;

            int libretaMayor = 0;
            string nombreMayor = "";
            double notaMayor = 0;

            int libretaMenor = 0;
            string nombreMenor = "";
            double notaMenor = 0;
            #endregion

            Console.WriteLine("Ingrese numero de libreta (corte -1)");
            int numlibreta = Convert.ToInt32(Console.ReadLine());

            while (numlibreta != -1 && contador < 100)
            {
                Console.WriteLine("Ingrese el nombre del alumno:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la nota:");
                double nota = Convert.ToDouble(Console.ReadLine());

                libreta[contador] = numlibreta;
                nombres[contador] = nombre;
                notas[contador] = nota;
                contador++;
              
                Console.WriteLine("Ingrese numero de libreta (corte -1)");
                numlibreta = Convert.ToInt32(Console.ReadLine());
              
            }

            
            for (int i = 0; i < contador; i++)
            {
                total += notas[i];
            }
            
            if (contador>0)
            {
                promedio = total / contador;
            }
            
            else
            {
                Console.WriteLine("Division por 0");
            }
                Console.WriteLine("" + promedio);

            for (int j = 0; j < contador; j++)
            {               
                acumulado += notas[j];

                if(notas[j] < notaMenor)
                {
                    libretaMayor = libreta[j];
                    nombreMayor =nombres[j];
                    notaMayor =notas[j];
                }

                if (notas[j] > notaMayor)
                {
                    libretaMenor = libreta[j];
                    nombreMenor = nombres[j];
                    notaMenor = notas[j];
                }

            }

            Console.WriteLine("Promedio: "+promedio);
            Console.WriteLine("Alumno: {0} / Lista: {1} / Nota mayor: {2}", nombreMayor, libretaMayor, notaMayor);
            Console.WriteLine("Alumno: {0} / Lista: {1} / Nota mayor: {2}", nombreMenor, libretaMenor, notaMenor);

















        }
    }
}


