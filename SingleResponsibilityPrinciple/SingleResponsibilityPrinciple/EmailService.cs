using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class EmailService
    {
        public void SendEmail(string address, string subject, string body)
        {
            Console.WriteLine($"Address: {address}, Subject: {subject}, Body: {body}");
        }
    }
}
