using BibliotecaCola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola miCola = new Cola();
            bool salir = true; 
            while (salir)
            {
                Console.WriteLine("1.-Generar ficha");
                Console.WriteLine("2.-Mostrar fichas generadas");
                int valor = int.Parse(Console.ReadLine());
                switch (valor)
                {
                    case 1:
                        Console.Write("Ingrese su nombre: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine(miCola.Encolar(nombre));
                        break;
                    case 2:
                        miCola.ImprimirCola();
                        break;
                }

            }  
            
        }
    }
}
