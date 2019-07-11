using System;
using FarmSystem.Test1.Interface;
using FarmSystem.Test1.Abstract;

namespace FarmSystem.Test1
{
    public class Hen: AnimalBase, IAnimalTalk, IAnimalRun
    {
        public Hen(): base(noOfLegs:2)
        { }

        public void Talk() =>  Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");

        public void Run() => Console.WriteLine("Hen is running");

        public override string ToString() => "Hen";
    }
}