using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternws
{
    public interface Icoffee
    {
        public int getCost();
        public void printDescription();
    }

    public class Coffee : Icoffee
    {
        public int getCost()
        {
            return 15;
        }

        public void printDescription()
        {
            Console.WriteLine("This is Coffee");
        }
    }

    public abstract class CoffeeDecoratior : Icoffee
    {
        protected Icoffee _coffee;
        public CoffeeDecoratior(Icoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual int getCost() => _coffee.getCost();
        public virtual void printDescription() => _coffee.printDescription();
    }

    public class MilkCoffee : CoffeeDecoratior
    {
        public MilkCoffee(Icoffee coffee): base(coffee)
        {

        }

        public override int getCost()
        {
            return base.getCost() + 10;
        }
        public override void printDescription()
        {
            base.printDescription(); 
            Console.WriteLine("and Milk");

        }
    }


}
