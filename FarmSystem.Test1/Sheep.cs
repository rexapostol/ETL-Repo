using System;
using FarmSystem.Test1.Interface;
using FarmSystem.Test1.Abstract;

namespace FarmSystem.Test1
{
    public class Sheep: AnimalBase, IAnimalTalk, IAnimalRun
    {
        public Sheep() : base(noOfLegs: 4)
        { }

        public void Talk() => Console.WriteLine("Sheep says baa!");
        
        public void Run() => Console.WriteLine("Sheep is running");

        public override string ToString() => "Sheep";
    }

}