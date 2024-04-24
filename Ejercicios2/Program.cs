using Ejercicio2;

namespace Ejercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese el nombre: ");
                String nombre = Console.ReadLine();
                personas[i] = new Persona(nombre);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(personas[i].ToString());
            }
        }
    }
}

