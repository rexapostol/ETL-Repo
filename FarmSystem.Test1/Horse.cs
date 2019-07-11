using System;
using FarmSystem.Test1.Interface;
using FarmSystem.Test1.Abstract;

namespace FarmSystem.Test1
{
    public class Horse: AnimalBase, IAnimalTalk, IAnimalRun
    {
        public Horse() : base(noOfLegs: 4)
        { }

        public void Talk() => Console.WriteLine("Horse says neigh!");

        public void Run() => Console.WriteLine("Horse is running");

        public override string ToString() => "Horse";

    }
}