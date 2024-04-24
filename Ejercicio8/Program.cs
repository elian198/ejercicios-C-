namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del perro: ");
            String nombre = Console.ReadLine();

            Animal perro = new Perro();
            perro.Nombre = nombre;
            Console.WriteLine(perro.Nombre);
            perro.Comer();
        }
    }
}
