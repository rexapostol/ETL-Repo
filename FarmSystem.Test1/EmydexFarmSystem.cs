using System;
using System.Linq;
using System.Collections.Generic;
using FarmSystem.Test1.Interface;
using FarmSystem.Test2.Interface;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //TEST 1
        public void Enter(IAnimal animal)
        {
            if (animal == null) return;

            if (!animals.Contains(animal))
            {
                animals.Add(animal);
            }

            Console.WriteLine(animal + " has entered the Emydex farm");

        }

        public void Enter(List<IAnimal> animals)
        {
            if (animals == null || animals.Count == 0) return;

            animals.ForEach((animal) => Enter(animal));
        }

        //TEST 2
        private List<IAnimal> animals = new List<IAnimal>();
        public void MakeNoise()
        {
            if (animals == null || animals.Count == 0)
            {
                Console.WriteLine("There are no animals in the farm");
                return;
            }

            animals.ForEach((animal) => (animal as IAnimalTalk)?.Talk());

        }

        //TEST 3
        public void MilkAnimals()
        {
            if (animals == null || animals.Count == 0)
            {
                Console.WriteLine("Cannot identify the farm animals which can be milked");
                return;
            }
            animals.ForEach((animal) => (animal as IMilkableAnimal)?.ProduceMilk());
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            var animalsCopy = this.animals.Select(a => a).ToList();
            animalsCopy.ForEach((animal) =>
            {
                ReleaseAnimal(animal);
            });

            if (this.animals ==null || this.animals.Count == 0)
            {
                Console.WriteLine("Emydex Farm is now empty");
            }
        }

        public void ReleaseAnimal(IAnimal animal)
        {
            if (animal == null) return;

            if (this.animals.Contains(animal))
            {
                this.animals.Remove(animal);
                Console.WriteLine(animal + " has left the farm");
            }
        }
    }
}