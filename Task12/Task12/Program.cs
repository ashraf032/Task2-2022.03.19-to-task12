
using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daixl edin");
            string numstr1 = Console.ReadLine();
            Console.WriteLine("Ikinci ededi daxil edin");
            string numstr2 = Console.ReadLine();
            Console.WriteLine("ucuncu ededi daxil edin");
            string numstr3 = Console.ReadLine();
            Console.WriteLine("Dorduncu ededi daxil edin");
            string numstr4 = Console.ReadLine();

            if (numstr1.Length+1>=6 && numstr2.Length+1 >= 6 && numstr3.Length+1 >= 6 && numstr4.Length+1 >= 6)
            {
                //Parsing input parametres
                int numint1 = int.Parse(numstr1);
                int numint2 = int.Parse(numstr2);
                int numint3 = int.Parse(numstr3);
                int numint4 = int.Parse(numstr4);
                //Persentage Parsed parametres
                double numpersantage1 = numint1 * 0.1;
                double numpersantage2 = numint2 * 0.1;
                double numpersantage3 = numint3 * 0.1;
                double numpersantage4 = numint4 * 0.1;
                //Ariphmetic methods
                double mathsum1 = numpersantage1 + numpersantage2 + numpersantage3 + numpersantage4;
                //Persentage Parsed parametr 2
                double numpersantage5 = numint1 * 0.15;
                double numpersantage6 = numint2 * 0.15;
                double numpersantage7 = numint3 * 0.15;
                double numpersantage8 = numint4 * 0.15;
                //Ariphmetic methods
                double mathsum2 = numpersantage5 + numpersantage6 + numpersantage7 + numpersantage8;
                //Result method
                double result = mathsum1 * mathsum2;
                double result10perc = result * 0.1;
                Console.WriteLine("-------");
                Console.WriteLine("Netice : ");
                Console.WriteLine(result10perc * 0.11);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz eded yanlisdir !!!");
            }


        }
    }
}
