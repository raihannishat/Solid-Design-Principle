using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class FormatedEmailService
    {
        public void SendEmail(string address, string subject, string body)
        {
            Console.WriteLine($"Address : {address}");
            Console.WriteLine($"Subject : {subject}");
            Console.WriteLine($"Body : {body}");
        }
    }
}
