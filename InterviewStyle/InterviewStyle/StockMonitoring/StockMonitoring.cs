using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewStyle.StockMonitoring
{
    public interface INotification
    {
        public void update(int amount);
    }

    public class MobileAppNotification : INotification
    {
        public void update(int amount)
        {
            Console.WriteLine($"Mobile App Alert : Stock Price Updated to {amount}");
        }
    }
    public class EMailNotification : INotification
    {
        public void update(int amount)
        {
            Console.WriteLine($"Email Alert: Stock Price Updated to {amount}");
        }
    }
    public interface IStockMonitoring
    {
        public void Subscribe(INotification notificationPlatform);
        public void UnSubscribe(INotification notificationPlatform);
        public void PriceChange(int amount);
    }
    public class StockMonitoring : IStockMonitoring
    {
        private List<INotification> _observers = new();
        public void Subscribe(INotification notificationPlatform)
        {
            _observers.Add(notificationPlatform);
        }
        public void UnSubscribe(INotification notificationPlatform)
        {
            _observers.Remove(notificationPlatform);
        }

        public void PriceChange(int amount)
        {
            foreach(INotification observer in _observers)
            {
                observer.update(amount);
            }
        }
    }
}