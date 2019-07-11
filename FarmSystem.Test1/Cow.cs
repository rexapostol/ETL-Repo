using System;
using FarmSystem.Test1.Interface;
using FarmSystem.Test2.Interface;
using FarmSystem.Test1.Abstract;

namespace FarmSystem.Test1
{
    public class Cow: AnimalBase, IAnimalTalk, IAnimalWalk, IAnimalRun, IMilkableAnimal
    {
        public Cow() : base(noOfLegs: 4)
        { }

        public void Talk() => Console.WriteLine("Cow says Moo!");

        public void Walk() => Console.WriteLine("Cow is walking");

        public void ProduceMilk() =>  Console.WriteLine("Cow produced milk");

        public void Run() => Console.WriteLine("Cow is running");

        public override string ToString() => "Cow";

    }
}