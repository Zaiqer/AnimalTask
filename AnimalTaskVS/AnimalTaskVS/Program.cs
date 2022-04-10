using System;

namespace AnimalTaskVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark shark = new Shark("Cekicbas", 301, 1500, 20);
            Dog dog = new Dog("Pitbull", "Jack", 5, 2);
            Cat cat = new Cat("Misir", "Tom", 2, 1);
            Eagle eagle = new Eagle("Sahin", 6, 10, 5);
            Console.WriteLine(shark.FullInfo());
            Console.WriteLine(dog.FullInfo());
            Console.WriteLine(cat.FullInfo());
            Console.WriteLine(eagle.FullInfo());
        }
    }
}
