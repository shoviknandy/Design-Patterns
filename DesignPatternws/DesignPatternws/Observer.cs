using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternws
{

    public interface INotificationFeed
    {
        void Update(string msg);
    }

    public class WhatsApp : INotificationFeed
    {
        public void Update(string msg)
        {
            Console.WriteLine($"[WhatsApp] Message: {msg}");
        }
    }

    public class Email : INotificationFeed
    {
        public void Update(string msg)
        {
            Console.WriteLine($"[Email] Message: {msg}");
        }
    }

    public class Telegram : INotificationFeed
    {
        public void Update(string msg)
        {
            Console.WriteLine($"[Telegram] Message: {msg}");
        }
    }
    public interface INotification
    {
        public void subscribe(INotificationFeed notificationtype);
        public void unSubscribe(INotificationFeed notificationtype);

        public void pushNotification(string msg);

    }
    class Observer : INotification
    {
        private HashSet<INotificationFeed> _platforms = new();

        public void subscribe(INotificationFeed notificationtype)
        {
            _platforms.Add(notificationtype);
        }

        public void unSubscribe(INotificationFeed notificationtype)
        {
            _platforms.Remove(notificationtype);
        }

        public void pushNotification(string msg)
        {
            foreach(var notification in _platforms)
            {
                notification.Update(msg);
            }
        }
    }


    public class obspattern
    {
        public void Execute()
        {
            var notifier = new Observer();

            var telegram = new Telegram();
            var email = new Email();
            var whatsapp = new WhatsApp();

            notifier.subscribe(email);
            notifier.subscribe(telegram);

            notifier.pushNotification("🔥 50% off on all items!");

            Console.WriteLine("--- Now unsubscribing Telegram ---");
            notifier.unSubscribe(telegram);

            notifier.pushNotification("⚠️ Last 2 hours left!");
        }
    }
}
