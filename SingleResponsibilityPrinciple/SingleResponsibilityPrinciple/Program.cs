using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberShipService = new MemberShipService();
            memberShipService.CreateAccount("raihan", "12345", "raihan@nishat.com");
            Console.WriteLine();
            memberShipService.PasswordRecovery("raihan", "raihan@nishat.com");
        }
    }
}
