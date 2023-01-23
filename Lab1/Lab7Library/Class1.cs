using System.Diagnostics.Contracts;

namespace Lab7Library
{
    public enum eClassificationAnimal
    {
        Herbivores,
        Carnivores,
        Omnivores
    }

    public enum eFavoriteFood
    {
        Meat,
        Plants,
        Everything
    }

    public abstract class Animal
    {
        private string country, name;
        private bool hideFromOtherAnimals;
        private eClassificationAnimal whatAnimal;

        public string Country { get => country; set => country = value; }
        public string Name { get => name; set => name = value; }
        public bool HideFromOtherAnimals { get => hideFromOtherAnimals; set => hideFromOtherAnimals = value; }
        public eClassificationAnimal WhatAnimal { get => whatAnimal; set => whatAnimal = value; }

        public Animal() { }
        public void Decontruct() { }
        public eClassificationAnimal GetClassificationAnimal() { return WhatAnimal; }
        public abstract eFavoriteFood GetFavoriteFood();
        public abstract void SayHello();

    }

    [AttributeForBykov]
    public class Cow : Animal
    {
        public Cow() 
        {
            WhatAnimal = eClassificationAnimal.Herbivores;
            HideFromOtherAnimals = false;
        }

        public override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.Plants;
        }

        public override void SayHello()
        {
            Console.WriteLine("Bruh");
        }
    }

    class AttributeForBykov : Attribute
    {
        public void Comment()
        {
            Console.WriteLine("Vingardium fartiosa!");
        }
    }

    [AttributeForBykov]
    public class Lion : Animal
    {
        public Lion()
        {
            WhatAnimal = eClassificationAnimal.Carnivores;
            HideFromOtherAnimals = false;
        }

        public override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.Meat;
        }

        public override void SayHello()
        {
            Console.WriteLine("Oraora!");
        }
    }

    [AttributeForBykov]
    public class Pig : Animal
    {
        public Pig()
        {
            WhatAnimal = eClassificationAnimal.Omnivores;
            HideFromOtherAnimals = true;
        }

        public override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.Everything;
        }

        public override void SayHello()
        {
            Console.WriteLine("Slava Ukraine!");
        }
    }



}