namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Saludar();

            Estudiante estudiante = new Estudiante(23);
            estudiante.Saludar();
            estudiante.verdad();
            estudiante.Estudiar();

            Profesor profesor = new Profesor(48);
            profesor.Saludar();
            profesor.Explicar();



        }
    }
}
