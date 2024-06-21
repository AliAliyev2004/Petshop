using ConsoleApp4;
Cat cat1 = new Cat("Nick", 12, "Gnd", 1, 12, "WW");
Fish fish1 = new Fish("Nicwk", 10, "Gnd", 1, 12, "WW");
Dog dog1 = new Dog("Nicwk", 10, "Gnd", 1, 12, "WW");
Birds bird1 = new Birds("Nicwk", 10, "Gnd", 1, 12, "WW");
Birds bird2 = new Birds("Ni2cwk", 210, "Gn2d", 1, 12, "WW");


List<Dog> dogList = new List<Dog>();
dogList.Add(dog1);
List<Cat> catList = new List<Cat>();
catList.Add(cat1);
List<Fish> fishList = new List<Fish>();
fishList.Add(fish1);
List<Birds> birdList = new List<Birds>();
birdList.Add(bird1);

Animals animals1 = new Animals(catList,dogList,birdList,fishList);

animals1.AddBird(bird2);


