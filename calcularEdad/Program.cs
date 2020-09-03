using System;

namespace calcularEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad");
            string valedad = Console.ReadLine();

            int edad = Convert.ToInt32(valedad);

            if (edad >= 0 && edad <= 10)
            {
                Console.WriteLine("Ustede es un Niño");
            }
            else if (edad >= 11 && edad <= 17)
            {
                Console.WriteLine("Usted es un Adolescente");
            }
            else if (edad >= 18 && edad <= 38)
            {
                Console.WriteLine("Usted es un Adulto Joven");
            }
            else if (edad >= 39 && edad <= 59)
            {
                Console.WriteLine("Usted esta en la Edad Mediana");
            }
            else if (edad >= 60 && edad <= 99)
            {
                Console.WriteLine("Usted es un Adulto Mayor");
            }
            else if (edad >= 100)
            {
                Console.WriteLine("Ya compro su tumba? o es una Momia?"); 
            }
            else {
                Console.WriteLine("Solo trabajamos con numeros");
            }

        }
    }
}
