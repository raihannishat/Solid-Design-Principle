using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class MemberShipService
    {
        public EmailService emailService = new EmailService();

        public void CreateAccount(string username, string password, string email)
        {
            Console.WriteLine("Account Created");
            emailService.SendEmail("example@example.com", "Account Regestration", "Your new Account is created");
        }

        public void PasswordRecovery(string username, string email)
        {
            Console.WriteLine("Account found");
            emailService.SendEmail("example@example", "Account Recovery", "Place click the link");
        }
    }
}
