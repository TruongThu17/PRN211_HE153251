using System;

namespace EX3
{
    public abstract class Car
    {
        protected int basePrice = 0, onRoadPrice = 0;
        public string ModelName { get; set; }
        public int BasePrice
        {
            set => basePrice = value;
            get => basePrice;
        }
    public int OnRoadPrice
    {
        set => onRoadPrice = value;
        get => onRoadPrice;
    }
    public static int SetAdditionalPrice()
    {
        Random random = new Random();
        int additionalPrice = random.Next(200_000, 500_000);
        return additionalPrice;
    }
    public abstract Car Clone();
    }// end Car

    public class Mustang : Car
    {
        public Mustang(string model) => (ModelName, BasePrice) = (model, 200_090);
        // Creating a shallow copy and returning it.
        public override Car Clone() => this.MemberwiseClone() as Mustang;

    }//end Mustang
    public class Bentley : Car
    {
        public Bentley(string model) => (ModelName, BasePrice) = (model, 300_000);
        // Creating a shallow co
        public override Car Clone() => this.MemberwiseClone() as Bentley;

    }//end Bentley
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Prototype Pattern Demo* ** \n");
            //Base or Original Copy
            Car mustang = new Mustang("Mustang EcoBoost");
            Car bentley = new Bentley("Continental GT Mulliner");
            // Console.WriteLine("Before clone, base prices:");
            Console.WriteLine($"Car is: {mustang.ModelName}, and it's base price is Rs.{mustang.BasePrice}");
            Console.WriteLine($"Car is: {bentley.ModelName}, and it's base price is Rs.{bentley.BasePrice}");
            Car Car;
            Car = mustang.Clone();
            // Working on cloned copy
            Car.OnRoadPrice = Car.BasePrice + Car.SetAdditionalPrice();
            Console.WriteLine($"Car is: {Car.ModelName}, and it's price is Rs. {Car.OnRoadPrice}");

            Car = bentley.Clone();
            // Working on cloned copy
            Car.OnRoadPrice = Car.BasePrice + Car.SetAdditionalPrice();
            Console.WriteLine($"Car is: {Car.ModelName}, and it's price is Rs. {Car.OnRoadPrice}");
            Console.ReadLine();
        }
    }


}
