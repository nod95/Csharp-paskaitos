using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_rem
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sk = 6;
            //Console.WriteLine("Skaiciaus " + sk + " 3 laipsnis: " + sk * sk * sk);
            //Console.WriteLine("Skaiciaus " + sk + " kvadratas " + sk * sk);

            //Console.WriteLine("Irasykite gerdos vardaa");
            //String gerdosvardas = Console.ReadLine();
            //Console.WriteLine("Gerdos vardas yra: " + gerdosvardas);

            //Console.WriteLine("Irasykite gerdos amziu");
            //int gerdosamz = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Gerdos amzius:" + gerdosamz);


            //Console.WriteLine("Iveskite 3 skaicius.");
            //Console.WriteLine("Iveskite pirmaji skaiciu: ");

            //int sk1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Iveskite antraji skaiciu: ");

            //int sk2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Iveskite treciaji skaiciu: ");

            //int sk3 = Convert.ToInt32(Console.ReadLine());

            //        if (sk1 == sk2)
            //        {
            //            Console.WriteLine("pirmas ir antras skaiciai lygus");
            //        }
            //            else if (sk1 != sk2)
            //                {
            //                    Console.WriteLine("pirmas ir antras skaiciai nelygus");
            //                }
            //if()

            //int reziupr = 1;
            //int reziupab = 10;

            //Console.WriteLine("Iveskite  skaiciu ");
            //int ivsk = Convert.ToInt32(Console.ReadLine());

            //if (ivsk >= reziupr && ivsk <= reziupab)
            //{
            //    Console.WriteLine("Skaicius patenka i rezius");
            //}
            //else if (ivsk<reziupr || ivsk > reziupab )
            //{
            //    Console.WriteLine("skaicius nepatenka i rezius");
            //}

            Console.WriteLine("Įveskite skaičių: ");
            int sk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ivestas skaicius yra: " + sk);

                if (sk % 2 == 0)
                    {
                        Console.WriteLine("Skaicius dalinasi is 2 :)");
                    }
                        else if(sk % 3 == 0 )
                            {
                                  Console.WriteLine("Skaicius dalinasi is 3");
                            }
            else if (sk % 4 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }
            else if (sk % 5 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 5");
            }
            else if (sk % 6 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 6");
            }
            else if (true)
            {
                Console.WriteLine("Klaida! Skaicius is nieko nesidalina. :(");
            }
        }







    }
}
