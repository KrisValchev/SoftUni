﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; private set; }
        public int Year { get;private set; }
        public IReadOnlyList<string> Authors { get; private set; }
        public Book(string title,int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }

        public int CompareTo(Book other)
        {
            int result=Year.CompareTo(other.Year);
            if(result==0)
            {
                result=Title.CompareTo(other.Title);
            }
            return result;
        }
        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
