namespace ConsoleApp4;

internal class Birds : Animal
{
    public Birds(string nickname, int age, string gender, uint energy, decimal price, string mealQuantity) : base(nickname, age, gender, energy, price, mealQuantity)
    {
    }
    public override void Play()
    {
        if (Energy > 0)
        {
            Console.WriteLine("Bird is playing ");
            Energy--;
        }
        else { Console.WriteLine("Bird is tired,It must sleep..."); }
    }
    public override void Eat()
    {
        Price++;
        Console.WriteLine("Bird is eating");
    }
    public override void Sleep()
    {
        Energy++;
        Console.WriteLine("Bird is sleeping");
    }
}
