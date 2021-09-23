using System;
using System.Collections.Generic;
using System.IO;

namespace karacsonyCLI
{
    class Program
    {
        static void Main(string[] args)
        {
          
            StreamReader sr = new StreamReader("diszek.txt");
            List<NapiMunka> lista = new List<NapiMunka>();
            while(!sr.EndOfStream)
            {
                lista.Add(new NapiMunka(sr.ReadLine()));
            }
            //4.feladat
            //foreach(var item in lista){console.writline(item.nap+""+item.fenyokesz+""+item.fenyo);}
            System.Console.WriteLine(NapiMunka.KeszultDb);

            //5.feladat
            
            bool VANe = false;
            foreach (var item in lista)
            {
                if (item.AngyalkaKesz==0 && item.FenyofaKesz==0 && item.HarangKesz==0)
                    //if (vane){console.writeline("volt olyan nap")}else{console.writeline("nem volt olyan nap")}


                {
                    VANe = true;
                }
            }
            System.Console.WriteLine(VANe);

            //6.feladat
            /*bool siker=false; 
             int bekertszam=0;
            while(!siker)
            {console.writeline("kérek 1 és 40 közötti számot");
            bekertszam=int.Pharse(console.readline()));
            if (bekertszam>=1 &&bekertszam<=40)
            if{siker=true;} else {console.writeline("kérem újra");
            }
            int harangdb=0;
            int angyaldb=0;
            int fenyodb=0;
            for (int i=0; i<bekertszam;i++)
            {angyaldb+=lista[i].angyalkesz+lista[i].angyaleladott;
            harangdb+=.....stb
            fenyodb+=..stb
            */
            Console.Write("Kérek egy számot: ");
            Console.ReadKey();
            int szam=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 15; i++)
            {

            }

            //7.feladat
            
           
        }
        
    }
}
