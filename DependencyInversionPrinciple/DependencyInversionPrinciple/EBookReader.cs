using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public class EBookReader
    {
        public PDFBook book { get; set; }

        public EBookReader(PDFBook book)
        {
            this.book = book;
        }

        public void OpenReader()
        {
            book.Read();
        }
    }
}
