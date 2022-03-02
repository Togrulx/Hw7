using System;
using System.Collections.Generic;
using System.Text;

namespace Hw7.cs
{
    public class Book
    {

        public string Code { get; set; }
        public string BookName;
        public string AuthorName;
        public int PageCount;

        public static int _count=1;

        
        public Book(string bookname, string authorname,int pagecount)
        {
            BookName = bookname;
            AuthorName = authorname;
            PageCount = pagecount;

            Code = $"{BookName[0..2].ToUpper()}{_count}";

            _count++;
        }


        public override string ToString()
        {
            return $"Book Code:{Code}\n" +
                $"Name:{BookName}\n" +
                $"Author Name:{AuthorName}\n" +
                $"Page Count:{PageCount}";
        }

    }
}
