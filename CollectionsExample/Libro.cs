using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CollectionsExample
{
    class Libro : IComparable<Libro>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageNuber { get; set; }

        public Libro(string title, string author, int pageNuber)
        {
            Title = title;
            Author = author;
            PageNuber = pageNuber;
        }

        public override string ToString()
        {
            return Title + " " + Author + " " + PageNuber;
        }

        public int CompareTo([AllowNull] Libro other)
        {
            return Title.CompareTo(other.Title);
        }
    }

    class LibroComparer : IComparer<Libro>
    {

        public LibroOrderType OrderType { get; set; }

        public LibroComparer(LibroOrderType orderType)
        {
            OrderType = orderType;
        }

        public int Compare([AllowNull] Libro l1, [AllowNull] Libro l2)
        {
            switch (OrderType)
            {
                case LibroOrderType.Title:
                    return l1.Title.CompareTo(l2.Title);
                case LibroOrderType.Author:
                    return l1.Author.CompareTo(l2.Author);
                case LibroOrderType.Pages:
                    return l1.PageNuber.CompareTo(l2.PageNuber);
                default:
                    return l1.Title.CompareTo(l2.Title);
            }
        }
    }

    enum LibroOrderType:int
    {
        Title = 0, Author = 1, Pages = 2
    }
}
