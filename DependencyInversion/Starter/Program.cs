using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Email : IMessage
    {
        public void Send() { }
    }

    public class Notification
    {
        private IMessage _Email;
        public Notification()
        {
            _Email = new Email();
        }

        public void Init(IMessage message)
        {
            _Email = message;
        }

        public void Notify() { _Email.Send(); }
    }

    class Program
    {
        static void Main(string[] args)
        {        
        }
    }
}
