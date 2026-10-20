namespace Laboratorio2_6_CuentaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre de cliente o titular de la cuenta");

            string nombreCliente = Console.ReadLine() ?? "";

            Console.WriteLine("Ingrese el Número de la cuenta");

            string numeroCuenta = Console.ReadLine() ?? "";

            Console.WriteLine("Ingrese el tipo de cuenta");

            string tipoCuenta = Console.ReadLine() ?? "";

            Console.WriteLine("Ingrese el saldo de la cuenta");

            decimal saldo = decimal.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("=======================================  ");
            Console.WriteLine("\t INFORMACIÓN CUENTA ");
            Console.WriteLine("======================================= \n");

            Console.WriteLine($"Nombre del Cliente: {nombreCliente}");
            Console.WriteLine($"Número de Cuenta: {numeroCuenta}");
            Console.WriteLine($"Tipo de Cuenta: {tipoCuenta}");
            Console.WriteLine($"Saldo RD$: {saldo:N2}");

            Console.WriteLine("\n=======================================");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

    }
}