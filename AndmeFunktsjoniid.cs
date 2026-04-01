using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Kontrolltöönr2
{
    public  class AndmeFunktsjoniid
    {
        //Ülesanne 1: Logi pidamine (Failikirjutamine)
        public static void KirjutaLogi(string teade)
        {
            string path = "logi.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                string rida = $"[{DateTime.Now}] - {teade}";
                sw.WriteLine(rida);
            }
        }
        // Ülesanne 2: Sõnastik ja Otsing (Dictionary)
        public static void RiigiOtsing()
        {
            Dictionary<string, string> riigid = new Dictionary<string, string>()
    {
        { "EE", "Eesti" },
        { "FI", "Soome" },
        { "DE", "Saksamaa" }
    };

            Console.Write("Sisesta riigi kood: ");
            string kood = Console.ReadLine().ToUpper();

            if (riigid.ContainsKey(kood))
            {
                Console.WriteLine("Riik: " + riigid[kood]);
            }
            else
            {
                Console.Write("Sellist koodi ei ole. Mis riik see on? ");
                string nimi = Console.ReadLine();
                riigid[kood] = nimi;
            }

            Console.WriteLine("\nKõik riigid sõnastikus:");
            foreach (var paar in riigid)
            {
                Console.WriteLine($"{paar.Key} - {paar.Value}");
            }
        }
        // Ülesanne 3:Failist lugemine ja analüüs

        public static Tuple<int, double> LoeJaArvuta()
        {
            try
            {
                string tekst = File.ReadAllText("arvud.txt");
                string[] osad = tekst.Split(',');

                List<int> arvud = new List<int>();
                foreach (string s in osad)
                {
                    arvud.Add(int.Parse(s.Trim()));
                }

                int summa = arvud.Sum();
                double keskmine = arvud.Average();

                return Tuple.Create(summa, keskmine);
            }
            catch
            {
                Console.WriteLine("Faili ei leitud või andmed on vigased.");
                return Tuple.Create(0, 0.0);
            }
        }
        //Ülesanne 5: Autopargi haldus(List ja loogika)
        public static void HaldaAutosid()
        {
            List<Auto> autod = new List<Auto>()
    {
        new Auto("Toyota", 5.5, 40),
        new Auto("BMW", 8.0, 15),
        new Auto("Honda", 6.0, 5)
    };

            // Leia suurima sõiduulatusega auto
            Auto parim = autod[0];
            foreach (var a in autod)
            {
                if (a.ArvutaSoiduulatus() > parim.ArvutaSoiduulatus())
                    parim = a;
            }

            Console.WriteLine($"Kõige suurema sõiduulatusega auto: {parim.Mudel} ({parim.ArvutaSoiduulatus()} km)");

            // Leia tankimist vajavad autod
            Console.WriteLine("\nTankimist vajavad autod:");
            foreach (var a in autod)
            {
                if (a.PaagisOnKutust < 10)
                    Console.WriteLine(a.Mudel);
            }

            // Salvesta autod faili
            SalvestaAutod(autod);
        }

        public static void SalvestaAutod(List<Auto> autod)
        {
            using (StreamWriter sw = new StreamWriter("autod.txt"))
            {
                foreach (var a in autod)
                {
                    sw.WriteLine($"{a.Mudel};{a.KutuseKulu};{a.PaagisOnKutust}");
                }
            }
        }

    }
}
