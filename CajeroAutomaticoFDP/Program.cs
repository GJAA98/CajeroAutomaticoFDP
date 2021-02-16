using System;

namespace CajeroAutomaticoFDP
{
    class Program
    {
        static void Main(string[] args)
        {
            int bDeMil = 18;
            int bDeQuinientos = 19;
            int bDeDocientos = 23;
            int bDeCien = 50;

            Console.WriteLine("Lista de Bancos:");

            Console.WriteLine("1. Ban Reservas");
            Console.WriteLine("2. Popular");
            Console.WriteLine("3. FDP Invesrments");
            Console.WriteLine("4. BHD Leon");

            int montoMaximo = ObtenerMontoMaximo();
            Console.WriteLine("Monto maximo:" + montoMaximo);
            Console.Write("Inserte un monto:");
            string valor = Console.ReadLine();
            int monto = int.Parse(valor);

            int cantDeMil = 0;
            int cantDeQuinientos = 0;
            int cantDeDocientos = 0;
            int cantDeCien = 0;

            if (monto>montoMaximo)
            {
                Console.WriteLine("Esta transaccion excede el monto maximo permitido de:" + montoMaximo);
            }
            else
            {
                int montoRestante = monto;

                if (montoRestante >= 1000 && bDeMil > 0)
                {
                    cantDeMil = (montoRestante / 1000);
                    montoRestante = montoRestante - (cantDeMil * 1000);
                }

                if (montoRestante >= 500)
                {
                    cantDeQuinientos = (montoRestante / 500);
                    montoRestante = montoRestante - (cantDeQuinientos * 500);
                }

                if (montoRestante >= 200)
                {
                    cantDeDocientos = (montoRestante / 200);
                    montoRestante = montoRestante - (cantDeDocientos * 200);
                }

                if (montoRestante >= 100)
                {
                    cantDeCien = (montoRestante / 100);
                    montoRestante = montoRestante - (cantDeCien * 100);
                }

                int restanteDemil = bDeMil - cantDeMil;
                int restanteDeQuiniento = bDeQuinientos - cantDeQuinientos;
                int restanteDeDociento = bDeDocientos- cantDeDocientos;
                int restanteDeCien = bDeCien- cantDeCien;

                if (montoRestante==0) {
                    Console.WriteLine("Transaccion existosa.");
                    Console.WriteLine("Billetes restantes:" + montoRestante);
                    Console.WriteLine("De Mil:" + restanteDemil);
                    Console.WriteLine("De Quinientos:" + restanteDeQuiniento);
                    Console.WriteLine("De Docientos:" + restanteDeDociento);
                    Console.WriteLine("De Cien:" + restanteDeCien);
                }
                else{
                    Console.WriteLine("El monto solicitado no puede ser dispensado.");
                }

            }            
        }
        public static int ObtenerMontoMaximo()
        {
            int montoMaximo;
            Console.WriteLine("Seleccione el banco donde desea retirar:");
            string banco = Console.ReadLine();
            if (banco == "3")
            {
                montoMaximo = 20000;
            }
            else if (banco == "2" || banco == "4" || banco == "1")
            {
                montoMaximo = 10000;
            }
            else
            {
                Console.WriteLine("Seleccion de banco invalida.");
                montoMaximo = ObtenerMontoMaximo();
            }
            return montoMaximo;
        }
    }
}
