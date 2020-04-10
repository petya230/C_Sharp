using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kutyak
{
    class Program
    {
        static List<Kutyak> kutyak = new List<Kutyak>();
        static List<KutyaNev> kutyanevek = new List<KutyaNev>();
        static List<KutyaFajtak> kutyafajtak = new List<KutyaFajtak>();

        struct Kutyak
        {
            public int id;
            public int fajta_id;
            public int nev_id;
            public int kor;
            public DateTime ellenorzes;
        }
        struct KutyaNev
        {
            public int id;
            public string nev;
        }
        struct KutyaFajtak
        {
            public int id;
            public string nev;
            public string eredetinev;
        }
        
        static void Main(string[] args)
        {
           
            KutyaNevek();
            Kutya_Fajtak();
            Kutyakok();

            //kiir(kutyak);
            //kiir(kutyanevek);
            //kiir(kutyafajtak);

            kutyanevek_szamolasa();
            AtlagKutyaKor();
            LegidosebbKutyu();

            Console.ReadKey();
        }
        static void KutyaNevek()
        {
            string[] kutyak = File.ReadAllLines(@"KutyaNevek.csv");
            for (int i = 1; i < kutyak.Length; i++)
            {
                KutyaNev kutya = new KutyaNev();
                string[] sor = kutyak[i].Split(';');
                kutya.id = int.Parse(sor[0]);
                kutya.nev = sor[1];
                kutyanevek.Add(kutya);
            }
        }
        static void Kutya_Fajtak()
        {
            string[] kutyak = File.ReadAllLines(@"KutyaFajtak.csv");
            for (int i = 1; i < kutyak.Length; i++)
            {
                KutyaFajtak kutya = new KutyaFajtak();
                string[] sor = kutyak[i].Split(';');
                kutya.id = int.Parse(sor[0]);
                kutya.nev = sor[1];
                kutya.eredetinev = sor[2];
                kutyafajtak.Add(kutya);
            }
        }
        static void Kutyakok()
        {
            string[] kutyakok = File.ReadAllLines(@"Kutyak.csv");
            for (int i = 1; i < kutyakok.Length; i++)
            {
                Kutyak kutya = new Kutyak();
                string[] sor = kutyakok[i].Split(';');
                kutya.id = int.Parse(sor[0]);
                kutya.fajta_id = int.Parse(sor[1]);
                kutya.nev_id = int.Parse(sor[2]);
                kutya.kor = int.Parse(sor[3]);
                kutya.ellenorzes = DateTime.Parse(sor[4]);
                kutyak.Add(kutya);
            }
        }
        static void kiir(List<Kutyak> kiirando)
        {
            Console.WriteLine(kiirando.Count);
            for (int i = 0; i < kiirando.Count; i++)
            {
                Console.WriteLine("id: " + kiirando[i].id + "\tfajta_id: " + kiirando[i].fajta_id + "\t nev_id: " + kiirando[i].nev_id  + "\t kor: " + kiirando[i].kor + "\t ellenorzes: " + kiirando[i].ellenorzes);
            }
        }
        static void kiir(List<KutyaNev> kiirando)
        {
            Console.WriteLine(kiirando.Count);
            for (int i = 0; i < kiirando.Count; i++)
            {
                Console.WriteLine("id: " + kiirando[i].id + "\tNev: " + kiirando[i].nev);
            }
        }
        static void kiir(List<KutyaFajtak> kiirando)
        {
            Console.WriteLine(kiirando.Count);
            for (int i = 0; i < kiirando.Count; i++)
            {
                Console.WriteLine("id: " + kiirando[i].id + "\tNev: " + kiirando[i].nev + "\teredeti nev: " + kiirando[i].eredetinev);
            }
        }
        static void kutyanevek_szamolasa()
        {
            int nevek = 0;
            for (int i = 0; i < kutyanevek.Count; i++)
            {
                nevek++;
            }
            Console.WriteLine("3. Feladat: Kutyanevek száma: " + nevek);
        }
        static void AtlagKutyaKor()
        {
            double osszes = 0;
            double atlag = 0;
            for (int i = 0; i < kutyak.Count; i++)
            {
                osszes += kutyak[i].kor;
            }
            atlag = osszes / kutyak.Count;
            atlag = Math.Round(atlag, 2);
            Console.WriteLine("6. Feladat: Kutyák átlag életkora: " + atlag);
        }
        static void LegidosebbKutyu()
        {
            int min = int.MinValue;
            int fajtaid = 0, nevid = 0;
            string fajta = "";
            string nev = "";

            for (int i = 0; i < kutyak.Count; i++)
            {
                if (kutyak[i].kor > min)
                {
                    min = kutyak[i].kor;
                    fajtaid = kutyak[i].fajta_id;
                    nevid = kutyak[i].nev_id;
                }
            }
            for (int i = 0; i < kutyanevek.Count; i++)
            {
                if (kutyanevek[i].id == nevid)
                    nev = kutyanevek[i].nev;
            }
            for (int i = 0; i < kutyafajtak.Count; i++)
            {
                if (kutyafajtak[i].id == fajtaid)
                    fajta = kutyafajtak[i].nev;
            }
                for (int i = 0; i < kutyak.Count; i++)
            {
                if (kutyak[i].kor == min)
                    Console.WriteLine("7. Feladat: Legidősebb kutya neve és fajtája: " + nev + ", " + fajta);
            }
        }
    }
}
