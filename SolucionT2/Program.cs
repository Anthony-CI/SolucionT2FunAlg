using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesarrolloT2;
namespace SolucionT2
{
    class Program
    {

        decimal saldo = 1000.00m; // Saldo inicial

        decimal ComisionRetiro = 8.00m;
        decimal ComisionDeposito = 2.00m;
        decimal MaximoRetiro = 500.00m;
        decimal MaximoDeposito = 1000.00m;

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                MostrarMenu();
                opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1:
                        RealizarRetiro(500.00m, 8.00m, 1000.00m);
                        break;
                    case 2:
                        RealizarDeposito( 1000.00m,  2.00m,  1000.00m);
                        break;
                    case 3:
                        MostrarSaldo(1000.00m);
                        break;
                    case 0:
                        Console.WriteLine("Gracias por usar el cajero automático. ¡Hasta pronto!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

            } while (opcion != 0);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("\nMenú del Cajero Automático");
            Console.WriteLine("1. Retirar");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Ver Saldo");
            Console.WriteLine("0. Salir");
        }

        static int LeerOpcion()
        {
            
                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                return opcion;

        }

        static decimal LeerMonto(string mensaje)
        {
        
                Console.Write(mensaje);
                decimal monto = Convert.ToDecimal(Console.ReadLine());
                return monto;
                                
        }

        static void RealizarRetiro(decimal MaximoRetiro, decimal ComisionRetiro, decimal saldo)
        {
            decimal retiro = LeerMonto("Ingrese el monto a retirar: S/ ");

            if (retiro <= 0)
            {
                Console.WriteLine("El monto debe ser mayor que cero.");
            }
            else if (retiro > MaximoRetiro)
            {
                Console.WriteLine("No puede retirar más de S/"+ MaximoRetiro);
            }
            else if (saldo >= (retiro + ComisionRetiro))
            {
                saldo -= (retiro + ComisionRetiro);
                Console.WriteLine("Ha retirado S/ " + retiro +". Comisión: S/ "+ComisionRetiro +". Saldo actual: S/ " + saldo);
                //return saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar el retiro incluyendo la comisión.");
            }
        }

        static void RealizarDeposito(decimal MaximoDeposito,decimal ComisionDeposito, decimal saldo)
        {
            decimal deposito = LeerMonto("Ingrese el monto a depositar: S/ ");

            if (deposito <= 0)
            {
                Console.WriteLine("El monto debe ser mayor que cero.");
            }
            else if (deposito > MaximoDeposito)
            {
                Console.WriteLine("No puede depositar más de S/ " + MaximoDeposito);
            }
            else if (deposito <= ComisionDeposito)
            {
                Console.WriteLine("El monto es demasiado bajo para cubrir la comisión.");
            }
            else
            {
                saldo += (deposito - ComisionDeposito);
                Console.WriteLine("Ha depositado S/ " + deposito + ". Comisión: S/ " + ComisionDeposito+ ". Saldo actual: S/ " + saldo);
            }
        }

        static void MostrarSaldo(decimal saldo)
        {
            Console.WriteLine($"Su saldo actual es: S/ " +saldo);
        }


    }
}
    
