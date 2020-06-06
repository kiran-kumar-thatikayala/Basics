using System;

namespace DecoratorPattern
{

    class Program
    {
        public abstract class Beverage
        {
            protected string description = "Unknown";
            public virtual string GetDescription()
            {
                return description;
            }
            public abstract double GetPrice();
        }


        public class Expresso : Beverage
        {
            public Expresso()
            {
                description = "Expresso";
            }
            public override double GetPrice()
            {
                return 2.0;
            }
        }

        public class HouseBlend : Beverage
        {
            public HouseBlend()
            {
                description = "HouseBlend";

            }
            public override double GetPrice()
            {
                return 3.0;
            }

        }

        public class DarkRoast : Beverage
        {
            public DarkRoast()
            {
                description = "DarkRoast";
            }
            public override double GetPrice()
            {
                return 4.0;
            }

        }

        public abstract class Decorator : Beverage
        {
            protected Beverage beverage;
            public Decorator(Beverage beverage)
            {
                this.beverage = beverage;
            }
            public override double GetPrice()
            {
                return beverage.GetPrice();
            }
        }
        public class MilkDecorator : Decorator
        {
            public MilkDecorator(Beverage beverage) : base(beverage)
            {
               
            }
            public override double GetPrice()
            {
                return 2.0 + base.GetPrice();
            }
            public override string GetDescription()
            {
                return "Milk" + " " + beverage.GetDescription();
            }
        }

        public class SoyDecorator : Decorator
        {

            public SoyDecorator(Beverage beverage) : base(beverage)
            {
                
            }
            public override double GetPrice()
            {
                return 2.0 + base.GetPrice();
            }
            public override string GetDescription()
            {
                return "soay" + " " + beverage.GetDescription();
            }
        }

        static void Main(string[] args)
        {
            Beverage beverage = new DarkRoast();
            beverage = new SoyDecorator(beverage);
            Console.WriteLine(beverage.GetDescription());
            beverage = new SoyDecorator(beverage);
            beverage = new MilkDecorator(beverage);
            Console.WriteLine($"Name: {beverage.GetDescription()}  Price: {beverage.GetPrice()}");
        }
    }
}

