using Ejercicio5;

namespace Ejercicios
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
                if (i == 0) personas[i] = new Profesor(nombre);
                else personas[i] = new Estudiante(nombre);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(personas[i].ToString());
            }
        }
    }
}
