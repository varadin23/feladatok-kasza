using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    public class Program
    {
        public class adatok
        {
            
            public string nev;
            public int elsolepes;
            public int masodiklepes;
            public int suly;
            public int magassag;

            List<adatok> adatoklista = new List<adatok>();
           
                
       

        }
        static void Main(string[] args)
        {
           StreamReader sr = new StreamReader("balkezesek.csv");
           sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string nev= sr.ReadLine();
                string[] adatoklista = nev.Split(' ');
                adatok a = new adatok();
                a.elsolepes = Convert.ToInt32(adatoklista[0]);
                a.masodiklepes = Convert.ToInt32(adatoklista[1]);
                a.suly = Convert.ToInt32(adatoklista[1]);
                a.magassag = Convert.ToInt32(adatoklista[1]);
            }
            sr.Close();

            Console.WriteLine(inchtocm(32));
            Console.ReadKey();
            
        }

        public static double inchtocm(int inch)
        {
            return inch*2.54;
        }
    }
}
