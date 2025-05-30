using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    internal class Program
    {
        static void Main(string[] args)
        {

        
            int[] numeros;
            
            numeros = new int[100];         
            int contador = 0;
            double suma = 0;
            int mayor = 0;
            int menor = 99999;
            int indmen, indmay;
            Console.WriteLine("Ingrese valor");
            int valor=Convert.ToInt32(Console.ReadLine());

            while (valor != -1)
            {
                numeros[contador] = valor;
                contador++;

                //suma promedio
                //suma += valor;

                ////mayor
                //if (valor > mayor)
                //{
                //    mayor = valor;
                //    indmay = contador;
                //}
                ////menor
                //if (valor < menor)
                //{
                //    menor = valor;
                //    indmen = contador;
                //}


                Console.WriteLine("Ingrese valor");
                valor = Convert.ToInt32(Console.ReadLine());

            }

            for (int n = 0; n < contador; n++)
            {
                Console.WriteLine("Posicion: {0} // Valor: {1}", n, numeros[n]);

                suma+= numeros[n];

                if (n == 0 || mayor > numeros[n])
                {
                    mayor = numeros[n];
                }
               
            }

            if (contador > 0)
            {
                Console.WriteLine("Promedio: " + 1.0*suma / contador);
                Console.WriteLine("Mayor: " + mayor);
            }
            else
            {
                Console.WriteLine("No hay valor");
            }




        }
    }
}
