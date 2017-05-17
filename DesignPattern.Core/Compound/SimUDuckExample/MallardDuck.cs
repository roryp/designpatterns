﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    public class MallardDuck : IQuackable
    {
        public Observable Observable { get; set; }

        public MallardDuck()
        {
            Observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            notifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            Observable.RegisterObserver(observer);
        }

        public void notifyObservers()
        {
            Observable.notifyObservers();
        }
    }
}
