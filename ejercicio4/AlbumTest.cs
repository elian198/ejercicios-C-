namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AlbumFotos albumFotos = new AlbumFotos();
            Console.WriteLine(albumFotos.GetNumeroPaginas());
            AlbumFotos albumFotos24 = new AlbumFotos(24);
            Console.WriteLine(albumFotos24.GetNumeroPaginas());
            AlbumFotos albumFotos64 = new SuperAlbumFotos();
            Console.WriteLine(albumFotos64.GetNumeroPaginas());

        }
    }
}
