using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Decir "Hola Mundo!"
            // 2) Decir "Hola [nombre]!"
            // 9) Salir

            // while

            // Mostrar el menú de opciones
            // Solicitar la opción al usuario

            StackNotas stackNotas = new StackNotas();
            stackNotas.Push("Primera nota");
            stackNotas.Push("Segunda nota");
            stackNotas.Push("Tercera nota");


            string opcion = "";
            while (opcion != "9")
            {
                opcion = "";
                // Pedir opción al usuario
                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "9")
                {
                    // Escapar caracter "
                    Console.WriteLine("1) Imprimir Nota");
                    Console.WriteLine("2) Agregar Nota (Push)");
                    Console.WriteLine("3) Quitar Nota (Pop)");
                    Console.WriteLine("4) Consultar un elemento (Peek)");
                    Console.WriteLine("9) Salir");


                    Console.WriteLine("Por favor selecciona una opción:");
                    opcion = Console.ReadLine();

                    // Validar opción ingresada
                    // hasta que se introduzca una opción correcta
                    // (mientras no se haya introducido una opción correcta)
                    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "9")
                    {
                        Console.WriteLine("La opción seleccionada no es correcta.");
                    }
                }

                // Manejar la opción seleccionada
                if (opcion == "1")
                {
                    stackNotas.PrintStack();
                }
                else if (opcion == "2")
                {
                    //  Push
                    Console.WriteLine("Agregar Nota:");
                    string nota = Console.ReadLine();
                    stackNotas.Push(nota);
                }
                else if(opcion == "3")
                {
                    //  Pop
                    string nota = stackNotas.Pop();
                    Console.WriteLine("Nota Removida:");
                    Console.WriteLine(nota);
                }
                else if(opcion == "4")
                {
                    //  Peek
                    string nota = stackNotas.Peek();
                    Console.WriteLine("Nota Consultada:");
                    Console.WriteLine(nota);
                }        
                else if (opcion == "9")
                {
                    Console.WriteLine("Hasta luego!");
                }

                //switch (opcion)
                //{
                    //case "1":
                        //  Hacer algo para opcion "1"
                        //Console.WriteLine("Hola Mundo!");
                        //break;
                    //case "2":
                        //  Hacer algo para opcion "2"
                        //Console.WriteLine("Introduce tu nombre:");
                        //string nombre = Console.ReadLine();
                        //Console.WriteLine("Hola " + nombre + "!");
                        //break;
                    //case "9":
                        //  Hacer algo para opcion "9"
                        //Console.WriteLine("Hasta luego!");
                        //break;
                    //default:
                        //  Hacer algo en caso contrario
                        //break;
                //}            
            }

        }
    }
}