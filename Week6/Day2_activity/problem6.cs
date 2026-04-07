using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface INotification
    {
        void Send(string message);
    }
    class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Notification : {message}");
        }
    }

    class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Notification :  {message}");
        }
    }

    class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Notification : {message}");
        }
    }

    class NotificationFactory
    {
        public static INotification CreateNotification(string message)
        {
            switch (message.ToLower())
            {
                case "email":
                    return new EmailNotification();
                    break;
                case "sms":
                    return new SMSNotification();
                    break;
                case "push":
                    return new PushNotification();
                    break;
                default: throw new ArgumentException("Invalid notification type");
                    break;
            }
        }
    }


    internal class problem6
    {
        static void Main()
        {
            INotification factory=NotificationFactory.CreateNotification("email");
            factory.Send("Email");
            INotification factory2 = NotificationFactory.CreateNotification("push");
            factory2.Send("push");
            INotification factory3 = NotificationFactory.CreateNotification("sms");
            factory3.Send("SMS");
        }
    }
}
