using System;

namespace cajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray; 
            Console.WriteLine("Por favor ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Usuario usuario = new Usuario(nombre, 0); // Iniciamos con saldo cero

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al cajero automático.");
                Console.WriteLine("1. Ver saldo");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        usuario.VerSaldo();
                        break;
                    case 2:
                        Console.Write("Ingresa el monto a depositar: ");
                        decimal montoDeposito = decimal.Parse(Console.ReadLine());
                        usuario.Depositar(montoDeposito);
                        break;
                    case 3:
                        Console.Write("Ingresa el monto a retirar: ");
                        decimal montoRetiro = decimal.Parse(Console.ReadLine());
                        usuario.Retirar(montoRetiro);
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar el cajero automático. ¡Adiós!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }
    }
}
