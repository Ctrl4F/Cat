using System;

namespace Cat
{
    class Program
    {
        class Cat
        {
            class Pet
            {
                string name;
                int age;
                double weight;
                double lifespan;
                public Pet(string _name, int _age)
                {
                    name = _name;
                    age = 0;
                    weight = 0.1;
                    lifespan = 0;
                }
                public string Name
                {
                    get { return name; }
                }
                public double Age
                {
                    get { return age; }
                }
                public double Weight
                {
                    get { return weight; }
                }
                public double Lifespan
                {
                    get { return lifespan; }
                }
                public void Eat()
                {
                    weight += 0.2;
                }
                public void Exercise()
                {
                    weight -= 0.1;
                }
                public void ShowPetdata()
                {
                    Console.WriteLine($"Name: {name};\n Age: {age};\n Weight: {weight}; \n Lifespan: {lifespan}; \n");
                }
            }
            string name;
            string color;
            double hunger;
            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;
                Console.WriteLine($"The cat {name} has been created.");
            }
            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hunger
            {
                get { return hunger; }
            }
            public void Sleep()
            {
                Console.WriteLine("The cat sleeps well.");
                hunger += 0.2;
            }
            public void Meow()
            {
                Console.WriteLine("Meow Meow!");
            }
            public void ShowCatDetails()
            {
                Console.WriteLine($"Name: {name};\n Color {color};\n Hunger: {hunger};\n");
            }
        }
        static void Main(string[] args)
        {
            Cat newCat = new Cat("Cutecat", "Black");
            while(newCat.Hunger != 1)
            {
                newCat.Sleep();
            }
            newCat.ShowCatDetails();
            newCat.Meow();
            Pet newPet = new Pet("Omega");
            newPet.ShowPetData();
        }
    }
}
