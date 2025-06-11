using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._3_Numeros_aleatorios
{
    internal class Program
    {

      

        static void QuickSort(int[] a, int inicio, int fin)
        {

            int p = a[inicio];
            int m = inicio + 1;
            int n = fin;
            int aux = 0;

            while (m <= n)
            {
                while (m <= fin && a[m] < p) m++;
                while (n > inicio && p <= a[n]) n--;

                if (m < n)
                {
                    aux = a[m];
                    a[m] = a[n];
                    a[n] = aux;
                }
            }
            a[inicio] = a[n];
            a[n] = p;


            if (inicio < n - 1)
                QuickSort(a, inicio, n - 1);
            if (n + 1 < fin)
                QuickSort(a, n + 1, fin);
        }

        static void Main(string[] args)
        {

            int[] num;
            num = new int[100];
            Random rmd = new Random();
            

            Console.WriteLine("Ingrese cuantos numeros quiere mostrar");
            int generada = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= generada; i++)
            {
                num[i] = rmd.Next(0, 201);

            }
            for (int i = 0; i < generada; i++)
            {
                Console.WriteLine("{0}:{1}", i, num[i]); //IMPRIMIR LISTA ORIGINAL SIN ORDENAMIENTOS
            }

            //ORDENAMIENTO BURBUJA MAYOR A MENOR

            Console.WriteLine("BURBUJA MAYOR A MENOR:");
            for (int m = 0; m < generada; m++)
            {
                for (int n = m + 1; n < generada; n++)
                {
                    if (num[n] > num[m])
                    {
                        int aux = num[m];
                        num[m] = num[n];
                        num[n] = aux;
                    }
                }
            }

            for (int n = 0; n < generada; n++)
            {
                Console.Write("{0} ", num[n]);
            }
            Console.WriteLine();
            //ORDENAMIENTO QUICKSORT MENOR A MAYOR

            Console.WriteLine("QUICKSORT MENOR A MAYOR:");
            QuickSort(num, 0, generada - 1); //LLAMADO METODO


            for (int n = 0; n < generada; n++)
                Console.Write("{0} ", num[n]);
            Console.WriteLine();

            //NUM ALEATORIO
            int numrandom = rmd.Next(0, 201);

            Console.WriteLine("Valor aleatorio generado: " + numrandom);

            int busqueda = numrandom;
            int indice = -1;
            


            for (int n = 0; n < num.Length && indice == -1; n++)
            {
                if (busqueda == num[n])
                {
                    indice = n;
                }
            }

            if (indice != -1)
            {
                Console.WriteLine("Valor: {0} / Encontrado en posicion {1}", busqueda, indice);
            }
            else
            {
                Console.WriteLine("Valor {0} no encontrado", numrandom);
            }




            






        }
    }
}

