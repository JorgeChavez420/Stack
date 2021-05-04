using System;
using System.Collections.Generic;

namespace Stack
{
    class StackNotas
    {
        List<string> notas = new List<string>();

        //  Push -> Agregar elemento
        //  Peek -> Ver elemento de arriba
        //  Pop -> Ver + Quitar
        //  Saber cuanto elementos tiene dentro

        public int count
        {
            get => this.notas.Count;
        }    

        //  Imprimir Stack

        public void Push(string nota)
        {
            //La parte de arriba de el Stack es el final de la List
            this.notas.Add(nota);
        }

        public string Pop()
        {
            //  1. Devolver valor
            //  2. Borrar

            //  Respaldar valor
            string value = this.notas[this.notas.Count -1];

            //  Borrar de la lista
            this.notas.RemoveAt(this.notas.Count -1);

            //  Devolver el valor respaldado
            return value; //  <----- La funcion llega hasta aqui
        }

        public string Peek()
        {
            return this.notas[this.notas.Count - 1];
        }

        public void PrintStack()
        {
            //  Todo: Implementar
            for(int i = this.notas.Count -1; i >= 0; i--)
            {
                Console.WriteLine(notas[i]);
            }    
        }        
    }
}        
