using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public class CorrectEpubBook : IBook
    {
        public void Read()
        {
            Console.WriteLine("This is read .epub file");
        }
    }
}
