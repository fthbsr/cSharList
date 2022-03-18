using System;
using System.Collections.Generic;

namespace list 
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> SayiListesi = new List<int>();

            SayiListesi.Add(89);
            SayiListesi.Add(26);
            SayiListesi.Add(78);
            SayiListesi.Add(67);
            SayiListesi.Add(45);
            SayiListesi.Add(34);
            SayiListesi.Add(23);


            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kirmizi");
            renkListesi.Add("Sari");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Yesil");

            foreach (var sayi in SayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            Console.WriteLine(SayiListesi.Count());

            //Listeden eleman cikarma 
                SayiListesi.Remove(45);
            //Index ile cikarma 

            renkListesi.RemoveAt(0);


            //listede arama

            foreach (var item in SayiListesi)
            {
                if(SayiListesi.Contains(23)){
                    Console.WriteLine(item);
                }

            }

            //verilen degerin indexini bulma 

            Console.WriteLine(renkListesi.BinarySearch("sari"));

            //diziyi listeye cevirme 

            string[] hayvanlar = {"Kedi" ,"Kopek" , "Aslan"};

            List<string> Hayvanlar = new List<string>(hayvanlar);

           Hayvanlar.Clear();

           Kulanicilar kullanici1= new Kulanicilar();

            List<Kulanicilar> kulanicilar = new List<Kulanicilar>();
            kullanici1.Isim = "hasan";
            kullanici1.Okul = "Lise";
            kullanici1.Yas = 15;

             Kulanicilar kullanici2= new Kulanicilar();
             kullanici2.Isim = "ayse";
            kullanici2.Okul = "universite";
            kullanici2.Yas = 21;

            kulanicilar.Add(kullanici1);
            kulanicilar.Add(kullanici2);

            foreach (var item in kulanicilar)
            {
                Console.WriteLine(item.Isim);
                Console.WriteLine(item.Okul);
                Console.WriteLine(item.Yas);


            }


        }

        class Kulanicilar{
            string isim ;

            string okul;

            int yas;

            public string Isim { get => isim; set => isim = value; }
            public string Okul { get => okul; set => okul = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
}