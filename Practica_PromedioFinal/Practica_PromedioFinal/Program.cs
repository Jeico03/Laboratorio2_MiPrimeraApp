namespace Practica_PromedioFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P1, P2, P3, P4, Prom, Examen, TrabajoF, PromFinal;

            Console.WriteLine("Ingrese la nota 1:");
            P1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2:");
            P2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3:");
            P3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 4:");
            P4 = int.Parse(Console.ReadLine());

            Prom = (P1 + P2 + P3 + P4) / 4 * 0.55;

            Console.WriteLine("Ingrese la nota obtenida en el examen:");
            Examen = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota obtenida en el trabajo final:");
            TrabajoF = int.Parse(Console.ReadLine());

            PromFinal = Prom + (Examen * 0.30) + (TrabajoF * 0.15);

            Console.WriteLine("La nota final es: " + PromFinal);

        }
    }
}