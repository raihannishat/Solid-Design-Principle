using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class MemberShipService
    {
        public void CreateAccount(string username, string password, string email)
        {
            Console.WriteLine("Account Created");
            var emailSrevice = new EmailService();
            emailSrevice.SendEmail($"{email}", "Account Regestration", "Your new Account is created");
        }

        public void PasswordRecovery(string username, string email)
        {
            Console.WriteLine("Account found");
            var emailSrevice = new FormatedEmailService();
            emailSrevice.SendEmail("example@example", "Account Recovery", "Place click the link");
        }
    }
}
