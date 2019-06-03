using System;

namespace Proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("INTRODUZCA UN VALOR");

            try {
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Se pulso un numero");
            }
            catch (Exception) {
                Console.WriteLine("INTRODUSCA UN NUMERO POR FAVOR....");
            }
            finally {
                Console.WriteLine("Siempre se ejecuta.......");
            }
            //if (a == 0 && b > 3) // AND
            //{
            //    Console.WriteLine("hola");
            //}
            //else {
            //    Console.WriteLine("ADIOS");
            //}

            //if (a == 0 || b > 3) // OR
            //{
            //    Console.WriteLine("hola");
            //}
            //else {
            //    Console.WriteLine("ADIOS");
            //}


            Console.WriteLine("Pulse un tecla para finalizar");
            Console.ReadLine();
        }
    }
}
