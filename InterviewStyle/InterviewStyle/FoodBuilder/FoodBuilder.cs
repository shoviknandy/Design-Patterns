using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewStyle.FoodBuilder
{
    public class FoodOrder
    {
        public List<string> mainCourse = new List<string>();
        public List<string> Appetizers = new List<string>();
        public List<string> Drinks = new List<string>();

        public int Fries = 0;
    }
    class FoodBuilder : IFoodBuilder
    {
        private FoodOrder _order = new();
        public IFoodBuilder addAppetizer(string appetizer)
        {
            _order.Appetizers.Add(appetizer);
            return this;
        }

        public IFoodBuilder addDrink(string drink)
        {
            _order.Drinks.Add(drink);
            return this;
        }

        public IFoodBuilder addFries(int count)
        {
            _order.Fries += count;
            return this;
        }

        public IFoodBuilder addMainCourse(string MainCourse)
        {
            _order.mainCourse.Add(MainCourse);
            return this;
        }

        public FoodOrder order()
        {
            return _order;
        }
        public void viewOrder()
        {
            Console.WriteLine($"Appetizers : {string.Join(",", _order.Appetizers)}");
            Console.WriteLine($"MainCourse : {string.Join(",", _order.mainCourse)}");
            Console.WriteLine($"Drinks : {string.Join(",", _order.Drinks)}");
            Console.WriteLine($"Fries : {_order.Fries}");
        }
    }
}
