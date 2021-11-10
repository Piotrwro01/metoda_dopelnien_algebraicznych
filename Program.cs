using System;
using System.Collections.Generic;

namespace SPOJ_transponowanie_macierzy
{

    class Program
    {
        static int[,] ZczytajTablice(int[,] tablica)//zczytuje tablice 2D
        {

            int rowLength = tablica.GetLength(0);
            int colLength = tablica.GetLength(1);


            for (int i = 0; i < rowLength; i++)
            {
                List<int> wiersz = new List<int>();
                for (int j = 0; j < colLength; j++)
                {
                    tablica[i, j] = int.Parse(Console.ReadLine());
                    wiersz.Add(tablica[i, j]);
                    Console.Clear();
                    foreach (int a in wiersz)
                    {
                        Console.Write(a + " ");
                    }
                }
                Console.Write(Environment.NewLine);
            }
            Console.Clear();
            return tablica;
        }
        static void WyswietlTablice(int[,] tablica)//wyswietla tablice 2D i chuj
        {
            int rowLength = tablica.GetLength(0);
            int colLength = tablica.GetLength(1);
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", tablica[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
        }

        public static int[,] OdwrocMacierz(int[,] tablica)
        {

            int w = tablica.GetLength(0);
            int h = tablica.GetLength(1);

            int[,] odwroconaTablica = new int[h, w];

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    odwroconaTablica[j, i] = tablica[i, j];
                }
            }

            return odwroconaTablica;

        }

        static void Main(string[] args)
        {

            //---------------------- POBRANIE DANYCH POCZĄTKOWYCH ----------------------
            Console.WriteLine("szerokosc: ");
            int szerokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("wysokosc: ");
            int wysokosc = int.Parse(Console.ReadLine());

            int[,] macierz = new int[wysokosc, szerokosc];
            macierz = ZczytajTablice(macierz);
            WyswietlTablice(macierz);
            // ---------------------- ODWROC TABLICE ----------------------
            int[,] odwroconaMacierz = new int[szerokosc, wysokosc];
            odwroconaMacierz = OdwrocMacierz(macierz);


            // ---------------------- WYSWIETLA ODWROCONA MACIERZ ----------------------
            //Console.Clear();
            Console.WriteLine("odwrotnosc macierzy: ");
            WyswietlTablice(odwroconaMacierz);
        }
    }
}


//using system;
//using system.collections.generic;

//namespace przeliczenie_macierzy
//{
//class program
//{
//    static int[,] zczytajtablice(int[,] tablica)//zczytuje tablice 2d
//    {
//        for (int i = 0; i < tablica.getlength(1); i++)
//        {
//            for (int j = 0; j < tablica.getlength(0); j++)
//            {
//                tablica[j, i] = int.parse(console.readline());

//            }
//            console.write(environment.newline);
//        }
//        return tablica;
//    }
//    static void wyswietltablice(int[,] tablica)//wyswietla tablice 2d i chuj
//    {
//        for (int i = 0; i < tablica.getlength(0); i++)
//        {
//            for (int j = 0; j < tablica.getlength(1); j++)
//            {
//                console.write(tablica[i, j] + " ");
//            }
//            console.write(environment.newline);
//        }
//    }

//    public static int[,] odwrocmacierz(int[,] tablica)
//    {
//        for (int wierszeindex = 0;
//             wierszeindex <= (tablica.getupperbound(0)); wierszeindex++)
//        {
//            for (int kolumnyindex = 0;
//                 kolumnyindex <= (tablica.getupperbound(1) / 2); kolumnyindex++)
//            {
//                int wartosctymczasowa = tablica[wierszeindex, kolumnyindex];
//                tablica[wierszeindex, kolumnyindex] =
//                  tablica[wierszeindex, tablica.getupperbound(1) - kolumnyindex];
//                tablica[wierszeindex, tablica.getupperbound(1) - kolumnyindex] =
//                  wartosctymczasowa;
//            }
//        }

//        return tablica;
//    }

//    static void main(string[] args)
//    {


//        int wysokosc = int.parse(console.readline());
//        int szerokosc = int.parse(console.readline());

//        int[,] macierz = new int[wysokosc, szerokosc];
//        macierz = zczytajtablice(macierz);
//        int[,] odwroconamacierz = new int[szerokosc, wysokosc];
//        odwroconamacierz = odwrocmacierz(macierz);
//        wyswietltablice(odwroconamacierz);
//    }
//    }
//}
