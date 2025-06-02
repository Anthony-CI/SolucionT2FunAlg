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


        static void Main(string[] args)
        {

            Cajero c = new Cajero();

            int opcion;
            

            do
            {
                MostrarMenu();
                opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese cantidad a retirar");
                        double ret = double.Parse(Console.ReadLine());
                        c.Retirar(ret);
                        Console.WriteLine("Ustded ha retirado " + " : " + ret + " " + "Cuenta con un saldo de " + " : " + c.MostrarSaldo());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese cantidad a depositar");
                        double depo = double.Parse(Console.ReadLine());
                        c.Depositar(depo);
                        Console.WriteLine("Usted depositó" + " : " +depo + "  " + "Cuenta con un saldo de " + " : " + c.MostrarSaldo());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Su saldo es"+" : " + c.MostrarSaldo());
                        Console.ReadKey();
                        Console.Clear();
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

    }
}
    
