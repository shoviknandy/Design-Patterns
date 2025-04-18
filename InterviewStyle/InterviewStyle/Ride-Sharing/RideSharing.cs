using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewStyle.Ride_Sharing
{
    public interface IRideSharing
    {
        public void Bookcar();
        public void GenerateOTP();
    }
    public sealed class Uber : IRideSharing
    {
        private static Lazy<Uber> _uber = new(()=> new Uber());
        private static int OTP;

        public static Uber getInstance()
        {
            return _uber.Value;
        }
        private Uber() { }
        public void Bookcar()
        {
            Console.WriteLine(" Your Car is Booked, Click on Generate OTP.");
            var otpObj = new Random();
            OTP = otpObj.Next(1000, 9999);
        }
        public void GenerateOTP()
        {
            Console.WriteLine($"Your OTP for ride : {OTP}");
        }
    }
}
