﻿using System;
using System.Linq;

namespace AnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Animal[] animals = new Animal[10];

            for (int i = 0; i < animals.Length; i++)
            {
                int randomNumber = random.Next(1, 5);

                switch (randomNumber)
                {
                    case 1:
                        animals[i] = new Dog();
                        break;
                    case 2:
                        animals[i] = new Cat();
                        break;
                    case 3:
                        animals[i] = new Bat();
                        break;
                    case 4:
                        animals[i] = new Bee();
                        break;
                }
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Sound());
                if (animal is IMammal mammal) Console.WriteLine($"Number of nipples: {mammal.NumberOfNipples}");
                if (animal is ICanFly canFly) Console.WriteLine($"Number of wings: {canFly.NumberOfWings}");
            }
        }
    }
}
