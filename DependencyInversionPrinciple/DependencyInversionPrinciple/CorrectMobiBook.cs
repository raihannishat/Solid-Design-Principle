using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public class CorrectMobiBook : IBook
    {
        public void Read()
        {
            Console.WriteLine("This is read .mobi file");
        }
    }
}
