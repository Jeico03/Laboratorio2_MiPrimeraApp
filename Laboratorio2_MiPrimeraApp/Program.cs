namespace Laboratorio2_MiPrimeraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string nombre = "Jeico Arias Brito";
            string carrera = "Ingeniería de Software";
            string motivo = "Realmente siempre me ha llamado la atención el mundo de la tecnología como tal para mí esta es la forma de agregar algo positivo al mundo";
            string bienvenida = ("¡Bienvenido a mi primera app de consola del curso de C#!");

            Console.WriteLine(bienvenida);

            Console.WriteLine();

            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Carrera/Profesión: {carrera}");
            Console.WriteLine($"Motivo por el que estudio programación: {motivo}");

            Console.WriteLine();

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}