using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCola
{
    public class Cola
    { 
        Nodo frente;
        Nodo final;
        int tamaño;
        int turnoActual; 

        public Cola()
        {
            frente = null;
            final = null;
            tamaño = 0;
            turnoActual = 0; 
        }

        public bool Vacia()
        {
            return frente == null;
        }

        public String Encolar(string nombre)
        {
            Nodo nuevo = new Nodo(turnoActual, nombre);
            turnoActual++; 

            if (Vacia())
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
            tamaño++;
            return $"Turno de {nombre} es {turnoActual}";
        }

        public void ImprimirCola()
        {
            Nodo recorrido = frente;
            while (recorrido != null)
            {
                Console.Write(recorrido.Nombre + "Turno "+turnoActual);
                recorrido = recorrido.Siguiente;
            }
        }


    }

    public class Nodo
    {
        public int Turno;
        public string Nombre;
        public Nodo Siguiente;

        public Nodo(int turno, string nombre)
        {
            Turno = turno;
            Nombre = nombre;
            Siguiente = null;
        }
    }
}