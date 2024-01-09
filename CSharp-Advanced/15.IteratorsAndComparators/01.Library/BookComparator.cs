using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare([AllowNull]Book book1, [AllowNull] Book book2)
        {
           int result=book1.CompareTo(book2);
            if(result==0)
            {
                result=book2.Year.CompareTo(book1.Year);
            }
            return result;
        }
    }
}
