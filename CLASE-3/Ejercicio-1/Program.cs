namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Moto moto = new Moto("Susuki", "EN-125");
            Auto auto = new Auto("Fiat", "UNO");
            ImprimirDatosVehiculo(moto);
            ImprimirDatosVehiculo(auto);
            
        }

        static void ImprimirDatosVehiculo(Vehiculo vehiculo)
        {
            vehiculo.ImprimirDatos();
            Console.WriteLine("------------------------------------------------");
        }
    }
}
