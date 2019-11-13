using System;
using System.Collections.Generic;

namespace CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pippo = new List<int>(20);
            pippo.Add(5);
            pippo.Add(5);
            pippo.Add(5);
            pippo.Add(5);
            pippo.Add(5);
            pippo.Add(5);
            pippo.Add(5);

            pippo.TrimExcess();

            List<int> pluto = new List<int>() {1,7,9,13,4};

            List<string> paperino = new List<string>() { "uno", "cavolo", "osso"};

            paperino.Add("cavallo");

            paperino.Insert(1, "ufo");

            //foreach (string item in paperino)
            //{
            //    Console.WriteLine(item);
            //}

            paperino[0] = "due";

            //for (int i = 0; i < paperino.Count; i++)
            //{
            //    Console.WriteLine(paperino[i]);
            //}

            List<Libro> libri = new List<Libro>();

            libri.Add(new Libro("odissea", "omero", 200));

            Libro nuovoLibro = new Libro("iliade", "omero", 150);

            libri.Add(nuovoLibro);

            libri.Add(new Libro("eneide", "virgilio", 230));

            libri.Add(new Libro("IT", "king", 500));

            libri.Add(new Libro("Oceano", "baricco", 500));

            libri.Sort(new LibroComparer(LibroOrderType.Pages));

            foreach (var item in libri)
            {
                Console.WriteLine(item);
            }

            //libri.Remove(nuovoLibro);

            //libri.RemoveAt(1);

            //Console.WriteLine();

            //foreach (var item in libri)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
