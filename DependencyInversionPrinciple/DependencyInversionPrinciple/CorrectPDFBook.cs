using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public class CorrectPDFBook : IBook
    {
        public void Read()
        {
            Console.WriteLine("This is read .pdf file");
        }
    }
}
