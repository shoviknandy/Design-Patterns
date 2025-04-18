using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewStyle.PaymentStrategy
{
    public interface IPaymentPlatform
    {
        public void processOrder(int amount, int orderId);
    }

    public class UPI : IPaymentPlatform
    {
        public void processOrder(int amount, int orderId)
        {
            Console.WriteLine($"Processing payment of amount : RS.{amount} for Order ID: {orderId} via {nameof(UPI)}");
        }
    }
    public class CreditCard : IPaymentPlatform
    {
        public void processOrder(int amount, int orderId)
        {
            Console.WriteLine($"Processing payment of amount : RS.{amount} for Order ID: {orderId} via {nameof(CreditCard)}");
        }
    }
    public class PayPal : IPaymentPlatform
    {
        public void processOrder(int amount, int orderId)
        {
            Console.WriteLine($"Processing payment of amount : RS.{amount} for Order ID: {orderId} via {nameof(PayPal)}");
        }
    }

    class PaymentStrategy
    {
        private IPaymentPlatform _paymentMethod;
        public void SetPaymentMethod(IPaymentPlatform paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void processOrder(int amount, int orderId)
        {
            _paymentMethod.processOrder(amount, orderId);
        }
    }
}
