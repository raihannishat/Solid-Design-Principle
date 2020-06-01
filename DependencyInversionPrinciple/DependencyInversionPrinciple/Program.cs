using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Incorrect reader
            var book = new PDFBook();
            var reader = new EBookReader(book);
            reader.OpenReader();


            // Correct reader
            var mobiBook = new CorrectMobiBook();
            var epubBook = new CorrectEpubBook();
            var pdfBook = new CorrectPDFBook();

            var readerForMobiBook = new CorrectEbookReader(mobiBook);
            readerForMobiBook.ReadBook();

            var readerForPDFBook = new CorrectEbookReader(pdfBook);
            readerForPDFBook.ReadBook();

            var readerForEpubBook = new CorrectEbookReader(epubBook);
            readerForEpubBook.ReadBook();
        }
    }
}
