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

            int rowLength = tablica.GetLength(0);
            int colLength = tablica.GetLength(1);

            int[,] odwroconaTablica = new int[colLength, rowLength];

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
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