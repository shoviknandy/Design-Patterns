using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternws
{
    public interface IPayment
    {
        public void pay(int amount);
    }

    public class UPI : IPayment
    {
        public void pay(int amount)
        {
            Console.WriteLine($"paid ${amount} via UPI");
        }
    }
    public  class NetBanking : IPayment
    {
        public void pay(int amount)
        {
            Console.WriteLine($"paid ${amount} via {nameof(NetBanking)}");
        }
    }
    class Strategy
    {
        private IPayment _paymentMode;

        public void paymentProcessor(IPayment processor)
        {
            _paymentMode = processor;
        }

        public void pay(int amount)
        {
            _paymentMode.pay(amount);
        }

    }
}
