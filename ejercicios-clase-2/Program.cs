namespace ejercicios_clase_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Persona> nombres = new List<Persona>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Escriba su nombre: ");
                string nombre = Console.ReadLine();
                nombres.Add(new Persona(nombre));
                Console.WriteLine(nombres[i].ToString());
            }
   
        }

      
    }
}
