using System.Numerics;

namespace ConsoleApp4;
internal class Animal
{


    public string Nickname { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public uint   Energy { get; set; }
    public decimal Price { get; set; }
    public string MealQuantity { get; set; }

    public Animal(string nickname, int age, string gender, uint energy, decimal price, string mealQuantity)
    {
        Nickname = nickname;
        Age = age;
        Gender = gender;
        Energy = energy;
        Price = price;
        MealQuantity = mealQuantity;
    }
    public virtual void Play()
    {
        Console.WriteLine("Anilmal is playing...");
    }
    public virtual void Sleep()
    {
        Console.WriteLine("Anilmal is sleeping...");
    }
    public virtual void Eat()
    {
        Console.WriteLine("Anilmal  is  Eating...");
    }

}
