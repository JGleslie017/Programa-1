using System;
namespace Fundamentos
{
    class EntradaSalida
    {
        public static void Main (string[] args)
        {
            string nombre;
            Console.WriteLine("Escribe tu nombre:");
            nombre = Console.Readline();
            Console.WriteLine("hola" + nombre);
            Console.Read();
        }
    }
}