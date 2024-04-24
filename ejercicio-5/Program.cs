namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese el nombre: ");
                if (i == 0)  personas[i] = new Profesor(Console.ReadLine());
                else personas[i] = new Estudiante(Console.ReadLine());
            }
            for(int i = 0; i < 3; i++)
            {
                if(i == 0) ((Profesor)personas[i]).Explicar();
                else ((Estudiante)personas[i]).Estudiar();
            }
        }
    }
}
