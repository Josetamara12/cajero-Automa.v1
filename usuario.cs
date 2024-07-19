using System;

namespace cajeroAutomatico
{
    class Usuario
    {
        public string Nombre { get; set; }
        public decimal Saldo { get; set; }

        public Usuario(string nombre, decimal saldoInicial)
        {
            Nombre = nombre;
            Saldo = saldoInicial;
        }

        public void VerSaldo()
        {
            Console.WriteLine($"Saldo actual de {Nombre}: ${Saldo}");
        }

        public void Depositar(decimal monto)
        {
            Saldo += monto;
            Console.WriteLine($"Has depositado ${monto}. Saldo actual: ${Saldo}");
        }

        public void Retirar(decimal monto)
        {
            if (monto > Saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
            }
            else
            {
                Saldo -= monto;
                Console.WriteLine($"Has retirado ${monto}. Saldo actual: ${Saldo}");
            }
        }
    }
}
