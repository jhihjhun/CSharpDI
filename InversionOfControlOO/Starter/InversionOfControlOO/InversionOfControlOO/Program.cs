using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControlOO
{
    interface IMessage
    {
        void Send();
    }

    class EmailService : IMessage
    {
        public void Send()
        {
            Console.WriteLine("EmailService Send Message");
        }
    }

    class SMSService : IMessage
    {
        public void Send()
        {
            Console.WriteLine("SMSService Send Message");
        }
    }

    static class Factory
    {
        public static EmailService GetEmailService()
        {
            return new EmailService();
        }
        public static SMSService GetSMSService()
        {
            return new SMSService();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //EmailService emailService = new EmailService();
            //emailService.Send();

            IMessage message = Factory.GetEmailService();
            message.Send();
        }
    }
}
