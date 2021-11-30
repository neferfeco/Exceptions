using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OSZTÁS\n=============");
            Console.WriteLine("Kivételkezelés nélkül\n--------------------");
            osztasKivetelKezelesNelkul();

            Console.WriteLine("Kivételkezeléssel\n--------------------");
            //osztasKivetelKezelessel();

        }
    
        public static void osztasKivetelKezelesNelkul()
        {
            Console.Write("Add meg az osztandó egész számot!: ");

            int osztando = Convert.ToInt32(Console.ReadLine());
            /*
             * Lehetséges hibák:
             * - 
             */

            Console.Write("Add meg az osztót (egész szám)!: ");

            int oszto = Convert.ToInt32(Console.ReadLine());
            /*
             * Lehetséges hibák:
             * - 
             * -
             */

            double hanyados = osztando / oszto;

            Console.WriteLine($"\n{osztando} / {oszto} = {hanyados}");

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

                Console.WriteLine($"\n{osztando} / {oszto} = {hanyados}");

                ok = true;

            } catch(DivideByZeroException e)
            {
                Console.WriteLine($"Az osztó nem lehet 0! {e.Message}");

            } catch (FormatException f)
            {
                Console.WriteLine($"Kérlek számokat adj meg! {f.Message}");
            }


        }



    }
}


