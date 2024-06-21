namespace ConsoleApp4;

internal class Dog : Animal
{
    public Dog(string nickname, int age, string gender, uint energy, decimal price, string mealQuantity) : base(nickname, age, gender, energy, price, mealQuantity)
    {
    }

    public override void Play()
    {
        if(Energy > 0)
        {
            Console.WriteLine("Dog is playing ");
            Energy--;
        }
        else { Console.WriteLine("Dog is tired,It must sleep..."); }
    }
    public override void Eat()
    {
        Price++;
        Console.WriteLine("Dog is eating");
    }
    public override void Sleep()
    {
        Energy++;
        Console.WriteLine("Dog is sleeping");
    }
}
