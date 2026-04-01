using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Kontrolltöönr2
{
    public class StartPage
    {
        
        public static void Main()
        {
             bool töötab = true;

            while (töötab)
              {
                 Console.WriteLine("Kontrolltöö nr 2: Andmete salvestamine ja klasside loomine");
                 Console.WriteLine("1. Kirjuta logisse");
                 Console.WriteLine("2. Riigi otsing");
                 Console.WriteLine("3. Loe arvud ja arvuta");
                 Console.WriteLine("4. Autopargi haldus");
                 Console.WriteLine("0. Välju");
                 Console.Write("Valik: ");

                 string valik = Console.ReadLine();

                 switch (valik)
                 {
                        case "1":
                            Console.Write("Sisesta logi teade: ");
                            string teade = Console.ReadLine();
                            AndmeFunktsjoniid.KirjutaLogi(teade);
                            break;

                        case "2":
                            AndmeFunktsjoniid.RiigiOtsing();
                            break;

                        case "3":
                            var tulemus = AndmeFunktsjoniid.LoeJaArvuta();
                            Console.WriteLine($"Summa: {tulemus.Item1}, Keskmine: {tulemus.Item2}");
                            break;

                        case "4":
                            AndmeFunktsjoniid.HaldaAutosid ();
                            break;

                        case "0":
                            töötab = false;
                            break;

                        default:
                            Console.WriteLine("Tundmatu valik.");
                            break;
                 }

                 Console.WriteLine();
           
            }
        }
    } 
}
