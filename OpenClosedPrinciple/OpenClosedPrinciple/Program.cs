using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberShip = new MemberShipService();
            memberShip.CreateAccount("raihan", "12345", "raihan@nishat.net");
            Console.WriteLine();
            memberShip.PasswordRecovery("raihan", "raihan@nishat.net");
        }
    }
}
