namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche(0);
            Console.Write("Gasolina: ");
            int gasolina = int.Parse( Console.ReadLine());
            Console.WriteLine(gasolina);
            coche.Repostar(gasolina);
            coche.Conducir();
        }
    }
}
