using System;
using System.Collections.Generic;
using System.Text;

namespace Kontrolltöönr2
{
    //Ülesanne 4: Oma Klassi loomine (Auto)
    public class Auto
    {
        public string Mudel { get; set; }
        // liitrit 100 km kohta
        public double KutuseKulu { get; set; }
        // liitrit
        public double PaagisOnKutust { get; set; }

        public Auto(string mudel, double kulu, double paagis)
        {
            Mudel = mudel;
            KutuseKulu = kulu;
            PaagisOnKutust = paagis;
        }

        public double ArvutaSoiduulatus()
        {
            return PaagisOnKutust / KutuseKulu * 100;
        }
    }
}
