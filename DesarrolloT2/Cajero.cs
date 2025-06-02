using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloT2
{
    public class Cajero
    {
        double saldo = 1000;

        public double Retirar(double retiro)
        {

            if (retiro <=0)
            {
                Console.WriteLine("La cantidad a retirar tiene que ser mayor a cero");
                return saldo;
            }

            if (retiro>saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return saldo;
            }

            if (retiro <= 500)
            {
                //forma larga
                double impuesto = 8;
                saldo = (saldo - retiro - impuesto);//forma larga igual actualiza la variable
                //forma reducida
                //saldo -= retiro;//foram corta actualiza el valor de la variblle nuevamente
                return saldo;
            }
            else
            {
                Console.WriteLine("Reriro maximo son 500");
                return saldo;
            }
 
          

        }


        public double Depositar(double deposito)
        {
            if(deposito <= 1000)
            {
                double impuesto = 2;
                saldo = saldo + deposito - impuesto;
                return saldo;
            }
            else
            {
                Console.WriteLine("Maximo de deposito es 1000");
                return saldo;
            }



        }

        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
