using System;
using System.Collections.Generic;
using static System.Console;

namespace EX2
{
    //Both the Lion and Tiger classes will
    //implement the IAnimal interface method.
    public interface IAnimal
    {
        void AboutMe();
    }

    //Lion class
    public class Lion : IAnimal
    {
        public void AboutMe() => WriteLine("This is Lion.");
    }

    //Tiger class
    public class Tiger : IAnimal
    {
        public void AboutMe() => WriteLine("This is Tiger.");
    }
    //Both LionFactory and TigerFactory will use this.
    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
    //LionFactory is used to create Lions
    public class LionFactory : AnimalFactory
    {
        //Creating a Lion
        public override IAnimal CreateAnimal() => new Lion();
    }

    public class TigerFactory : AnimalFactory
    {
        //Creating a Tiger
        public override IAnimal CreateAnimal() => new Tiger();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Factory Method Pattern Demo. ***\n");
            // Create a list AnimalFactory included TigerFactory and LionFactory
            List<AnimalFactory> animalFactoryList = new List<AnimalFactory>
            {
                new TigerFactory(),
                new LionFactory()
            };

            foreach (var animal in animalFactoryList)
            {
                animal.CreateAnimal().AboutMe();



            }
            ReadLine();
        }
    }
}
