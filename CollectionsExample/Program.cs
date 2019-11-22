using System;
using System.Collections.Generic;
using System.Linq;

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

            Libro libroTrovato;

            foreach (Libro libro in libri)
            {
                if (libro.Author == "omero")
                {
                    libroTrovato = libro;
                    break;
                }
            }

       


            Libro superLibro = new Libro("Sandokan", "Salgari", 130);

            Console.WriteLine(superLibro.getReadingTime());

            Libro.getReadingTime(600);

            Libro.Discount = 30;

            Libro libroTrovato2 = libri.Find((l1) => l1.PageNumber > 150);
            List<Libro> libriDiOmero = libri.FindAll(l1 => l1.Author == "omero");

            int indice = libri.FindIndex(l1 => l1.Author == "omero");

            Dictionary<string, Libro> LibriPerTitolo = new Dictionary<string, Libro>()
            {
                ["Ciao Mamma"] = new Libro("Ciao Mamma", "Gino Bianchi", 300),
                ["Vite Sospese"] = new Libro("Vite Sospese", "Gino Giorfi", 250),
                ["Mamme Sospese"] = new Libro("Mamme Sospese", "Pola Giorfi", 250),
            };

            Libro libroSelezionato = LibriPerTitolo["Ciao Mamma"];

            foreach (string titolo in LibriPerTitolo.Keys)
            {
                Console.WriteLine(titolo);
            }

            Console.WriteLine("///////////////");

            libri.ToDictionary(l1 => l1.Title, l1 => l1.Author);
            var lookUp = libri.ToLookup(l1 => l1.Author, l1 => l1);

            List<Libro> libriOmero = lookUp["omero"].ToList();

            foreach (var libro in libriDiOmero)
            {
                Console.WriteLine(libro);
            }
        }

        static bool TrovaOmero(Libro libro)
        {
            if (libro.Author == "omero")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
