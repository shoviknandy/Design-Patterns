using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace InterviewStyle.ShoppingCart
{
    public interface IShoppingCart
    {
        public Double getTotal();
    }
    class ShoppingCart : IShoppingCart
    {
        private int _Cost;
        public ShoppingCart(int cost)
        {
            _Cost = cost;
        }
        public Double getTotal()
        {
            return _Cost;
        }
    }

    public abstract class DiscountDecorator : IShoppingCart
    {
        protected IShoppingCart _shoppingCart;

        public DiscountDecorator(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public virtual Double getTotal() => _shoppingCart.getTotal();
    }

    public class CouponDiscount : DiscountDecorator
    {
        public CouponDiscount(IShoppingCart shoppingCart) : base(shoppingCart)
        {
        }
        public override Double getTotal()
        {
            var Cost = base.getTotal();
            return Cost > 100 ? Cost - 100 : 0;

        }
    }
    public class FestiveDiscount:DiscountDecorator
    {
        public FestiveDiscount(IShoppingCart shoppingCart) : base(shoppingCart) { }
        public override Double getTotal()
        {
            var Cost = base.getTotal();
            return Cost>0 ?Cost - Cost * (0.1) : 0;
        }
    }

    public class LoyaltyDiscount : DiscountDecorator
    {
        public LoyaltyDiscount(IShoppingCart shoppingCart) : base(shoppingCart)
        {
        }

        public override double getTotal()
        {
            var Cost = base.getTotal();
            return Cost>0 ? Cost - Cost * (0.05) : 0;
        }
    }
}
