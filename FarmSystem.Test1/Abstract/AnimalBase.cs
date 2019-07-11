using System;
using FarmSystem.Test1.Interface;

namespace FarmSystem.Test1.Abstract
{
    public abstract class AnimalBase: IAnimal
    {
        private readonly int _noOfLegs;
        private readonly string _id;

        public AnimalBase(int noOfLegs)
        {
            this._noOfLegs = noOfLegs;
            this._id = Guid.NewGuid().ToString();
        }

        public int NoOfLegs { get { return _noOfLegs; } }
        public string Id { get { return _id; } }
    }
}
