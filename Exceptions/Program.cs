using System;



namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string cim = "EGÉSZ SZÁMOK OSZTÁSA";
            string cimkivetelNelkul = "Kivételkezelés nélkül";
            string cimKivetellel = "Kivételkezeléssel";

            Console.WriteLine($"\n{cim}\n{alahuzasKiemeles(cim.Length, '=')}\n");


            //OSZTÁS KIVÉTELKEZELÉS NÉLKÜL           
            //Console.WriteLine($"{cimkivetelNelkul}\n{alahuzasKiemeles(cim.Length, '-')}");
            //osztasKivetelKezelesNelkul();


            //OSZTÁS KIVÉTELKEZELÉSSEL
            Console.WriteLine($"{cimKivetellel}\n{alahuzasKiemeles(cim.Length, '-')}");
            osztasKivetelKezelessel();

        }
    
        public static void osztasKivetelKezelesNelkul()
        {
            Console.Write("Add meg az osztandó egész számot!: ");

            int osztando = Convert.ToInt32(Console.ReadLine());
            /*
             * Lehetséges hibák:
             * - megadott adat nem szám
             */

            Console.Write("Add meg az osztót (egész szám)!: ");

            int oszto = Convert.ToInt32(Console.ReadLine());
            /*
             * Lehetséges hibák:
             * - megadott adat nem szám
             * - megadott érték a 0
             */

            double hanyados = osztando / oszto;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{osztando} / {oszto} = {hanyados}\n");
            Console.ResetColor();
        }


        public static void osztasKivetelKezelessel()
        {
            bool ok = false;

            while(!ok)
            try
            {
                Console.Write("Add meg az osztandó egész számot!: ");

                int osztando = Convert.ToInt32(Console.ReadLine());

                Console.Write("Add meg az osztót (egész szám)!: ");

                int oszto = Convert.ToInt32(Console.ReadLine());

                double hanyados = osztando / oszto;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{osztando} / {oszto} = {hanyados}\n");
                Console.ResetColor();

                ok = true;

            } catch(DivideByZeroException e)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n\tAz osztó nem lehet 0! {e.Message}\n");
                Console.ResetColor();

            } catch (FormatException f)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\tKérlek számot adj meg! {f.Message}\n");
                Console.ResetColor();
            }


        }





        public static string alahuzasKiemeles(int db, char jel) {

            string disz = "";

            for (int i = 0; i < (db + 3); i++) disz += jel;

            return disz;
        }

    }
}


