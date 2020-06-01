using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public class CorrectEbookReader
    {
        public IBook book { get; set; }

        public CorrectEbookReader(IBook book)
        {
            this.book = book;
        }

        public void ReadBook()
        {
            book.Read();
        }
    }
}
