namespace ConsoleApp4;

internal class Fish : Animal
{
    public Fish(string nickname, int age, string gender, uint energy, decimal price, string mealQuantity) : base(nickname, age, gender, energy, price, mealQuantity)
    {
    }
    public override void Play()
    {
        if (Energy > 0)
        {
            Console.WriteLine("Fish is playing ");
            Energy--;
        }
        else { Console.WriteLine("Fish is tired,It must sleep..."); }
    }
    public override void Eat()
    {
        Price++;
        Console.WriteLine("Fish is eating");
    }
    public override void Sleep()
    {
        Energy++;
        Console.WriteLine("Fish is sleeping");
    }
}
