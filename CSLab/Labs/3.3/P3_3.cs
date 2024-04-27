﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab.Labs._3._3
{
    internal class P3_3
    {
        public void main(string[] args)
        {
            Transakcja t1 = new Transakcja(DateTime.Now.AddDays(-1), "Test title 1", 1);
            Transakcja t2 = new Transakcja(DateTime.Now.AddDays(-40), "Test title 2", 2);
            Transakcja t3 = new Transakcja(DateTime.Now.AddDays(-10), "Test title 3", 3);
            Transakcja t4 = new Transakcja(DateTime.Now.AddDays(-100), "Test title 4", 4);
            Transakcja t11 = new Transakcja(DateTime.Now.AddDays(-12), "Test title 1", -1);
            Transakcja t22 = new Transakcja(DateTime.Now.AddDays(-12), "Test title 2", -2);
            Transakcja t33 = new Transakcja(DateTime.Now.AddDays(-22), "Test title 3", -3);
            Transakcja t44 = new Transakcja(DateTime.Now.AddDays(-100), "Test title 4", -1);
            Osoba osoba = new Osoba("test,", "nazwisko", 25.0f);
            Konto konto = new Konto("asdfadsf",osoba, DateTime.Now.AddDays(-100));
            konto.WypiszInformacjeOKoncie();
            t1.wypiszNaKonsole();

            konto.dodajTransackje(t1);
            konto.dodajTransackje(t2);
            konto.dodajTransackje(t3);
            konto.dodajTransackje(t4);
            konto.dodajTransackje(t11);
            konto.dodajTransackje(t22);
            konto.dodajTransackje(t33);
            konto.dodajTransackje(t44);
            Debug.Assert(konto.getSaldo() == 3);
            _ = konto["uznania"][12];
            


        }
    }
}
