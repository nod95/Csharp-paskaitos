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

            //Console.WriteLine("Įveskite skaičių: ");
            //int sk = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("ivestas skaicius yra: " + sk);

            //    if (sk % 2 == 0)
            //        {
            //            Console.WriteLine("Skaicius dalinasi is 2 :)");
            //        }
            //            else if(sk % 3 == 0 )
            //                {
            //                      Console.WriteLine("Skaicius dalinasi is 3");
            //                }
            //else if (sk % 4 == 0)
            //{
            //    Console.WriteLine("Skaicius dalinasi is 4");
            //}
            //else if (sk % 5 == 0)
            //{
            //    Console.WriteLine("Skaicius dalinasi is 5");
            //}
            //else if (sk % 6 == 0)
            //{
            //    Console.WriteLine("Skaicius dalinasi is 6");
            //}
            //else if (true)
            //{
            //    Console.WriteLine("Klaida! Skaicius is nieko nesidalina. :(");
            //}

            //Console.WriteLine("Iveskite du skaičius: ");

            //Console.WriteLine("Įveskite pirmąjį skaičių: ");
            //int sk1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Iveskite antraji skaiciu: ");
            //int sk2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Jūsų įvesti skaičiai yra: {0} ir {1}", sk1, sk2);

            //if (sk1 > sk2)
            //{
            //    Console.WriteLine("Pirmasis skaičius yra didesnis už antrąjį");
            //}
            //else if (sk2 > sk1)
            //{
            //    Console.WriteLine("Antrasis skaičius didesnis už pirmąjį");
            //}
            //else if (sk2 == sk1)
            //{
            //    Console.WriteLine("Skaičiai yra lygūs");
            //}

            ///Patikrinti ar skaičius yra teigiamas ir lyginis

            //Console.WriteLine("Įveskite teigiama skaičiu");
            //int sk1 = Convert.ToInt32(Console.ReadLine());

            //if (sk1 > 0 && sk1 % 2 == 0)
            //{
            //    Console.WriteLine("Skaicius yra teigiamas");
            //}
            //else if (sk1 < 0)
            //{
            //    Console.WriteLine("Skaicius yra neigiamas!!!!");
            //}
            //else if (sk1 % 2 != 0)
            //{
            //    Console.WriteLine("Skaicius yra nelyginis");
            //}

            //Switch!!

            Console.WriteLine("----------Kavos aparatas---------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("--1 Latte-----4 Moca-------------");
            Console.WriteLine("--2 Espress---5 SU pienu---------");
            Console.WriteLine("--3 Juoda-----6 Arbata-----------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-------Rinkitės gėrimą-----------");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch(pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Jūsų pasirinkimas Latte :)");
                break;

                case 2:
                    Console.WriteLine("Jūsų pasirinkimas Espresso :)");
                break;

                case 3:
                    Console.WriteLine("Jūsų pasirinkimas Juoda :)");
                    break;

                case 4:
                    Console.WriteLine("Jūsų pasirinkimas Moca :)");
                    break;

                case 5:
                    Console.WriteLine("Jūsų pasirinkimas Su pienu :)");
                    break;

                case 6:
                    Console.WriteLine("Jūsų pasirinkimas Arbata");
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra!");
                    break;
            }


        }







    }
}
