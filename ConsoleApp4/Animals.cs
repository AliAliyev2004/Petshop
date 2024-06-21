using ConsoleApp4;


internal class Animals
{
    public Animals(List<Cat> cats, List<Dog> dogs, List<Birds> birds, List<Fish> fishes)
    {
        Cats = cats;
        Dogs = dogs;
        Birds = birds;
        Fishes = fishes;
    }

    public List<Cat> Cats { get; set; } = new List<Cat>();
    public List<Dog> Dogs { get; set; } = new List<Dog>();
    public List<Birds> Birds { get; set; } = new List<Birds>();
    public List<Fish> Fishes { get; set; } = new List<Fish>();


    public void AddCat(Cat cat)
    {
        Cats.Add(cat);
    }

    public void AddDog(Dog dog)
    {
        Dogs.Add(dog);
    }

    public void AddBird(Birds bird)
    {
        Birds.Add(bird);
    }

    public void AddFish(Fish fish)
    {
        Fishes.Add(fish);
    }
    public void RemovePet(string nickname)
    {
        for (int i = 0; i < Cats.Count; i++)
        {
            if (Cats[i].Nickname == nickname)
            {
                Cats.RemoveAt(i);
                return;
            }
        }

        for (int i = 0; i < Dogs.Count; i++)
        {
            if (Dogs[i].Nickname == nickname)
            {
                Dogs.RemoveAt(i);
                return;
            }
        }

        for (int i = 0; i < Birds.Count; i++)
        {
            if (Birds[i].Nickname == nickname)
            {
                Birds.RemoveAt(i);
                return;
            }
        }

        for (int i = 0; i < Fishes.Count; i++)
        {
            if (Fishes[i].Nickname == nickname)
            {
                Fishes.RemoveAt(i);
                return;
            }
        }
    }
    
}



    
