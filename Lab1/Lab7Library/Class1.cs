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

}