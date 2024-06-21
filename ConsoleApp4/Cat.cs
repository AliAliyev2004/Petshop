namespace ConsoleApp4;

internal class Cat : Animal
{
    public Cat(string nickname, int age, string gender, uint energy, decimal price, string mealQuantity) : base(nickname, age, gender, energy, price, mealQuantity)
    {

    }
    public override void  Play()
    {
        if (Energy>0)
        {
            Console.WriteLine("Cat is playing....");
            Energy = Energy - 1;
        }

        else  { Console.WriteLine("Cat is tired,It must sleep..."); }
    }
    public override void Sleep()
    {
        Energy = Energy + 1;
        Console.WriteLine("Cat is sleeping");
    }
    public override void Eat()
    {
        Price ++;
        Console.WriteLine("Cat is eating ");
    }
    
}
