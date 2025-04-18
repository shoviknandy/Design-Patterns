using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InterviewStyle.FoodBuilder
{
    interface IFoodBuilder
    {
        public IFoodBuilder addMainCourse(string MainCourse);
        public IFoodBuilder addDrink(string drink);
        public IFoodBuilder addAppetizer(string appetizer);
        public IFoodBuilder addFries(int count);

        public FoodOrder order();

        public void viewOrder();
    }
}
