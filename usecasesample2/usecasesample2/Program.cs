using usecasesample2;

Bird b1 = new Bird
{
    Name = "Bird",
    Price = 2000,
    EggSize = 10,
    FeatherColor = "green"
  
};

Fish f1 = new Fish
{
    Name = "fish",
    Price = 500,
    FishType = "samll"
};

Dog d1 = new Dog
{
    Name = "dog",
    BreedName = "Pitbull",
    Colour = "black",
    Price = 20000
};

Cat c1 = new Cat
{
    Name = "cat",
    Price = 2000,
    Colour = "white",
    Type = "normal"
};

b1.Pname();
b1.Feature();
Console.WriteLine();
f1.Pname();
f1.Feature();
Console.WriteLine();
d1.Pname();
d1.Feature();
Console.WriteLine();
c1.Pname();
c1.Feature();
Console.WriteLine();








