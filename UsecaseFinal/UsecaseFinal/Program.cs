using UsecaseFinal;

SportsCar sp = new SportsCar
{
    Make = "Lamborgini",
    Model = "Urus",
    Year = 2022,
    EngineSize = "100",
    TopSpeed = 360
};

Sedan s = new Sedan
{
    Make = "Mercedes-Benz",
    Model = "S-class",
    Year = 2022,
    PassangerCapacity = 4,
    TrunkCapacity = 36
};

Suv sv = new Suv
{
    Make = "Bmw",
    Model = "X1",
    Year = 2022,
    TowingCapacity = 200,
    GroundClearance = 36
};


sp.Mname();
sp.Value();
sp.Spec();
sp.Display();
sp.Get();
Console.WriteLine();
s.Mname();
s.Value();
s.Spec();
s.Display();
s.Get();
Console.WriteLine();
sv.Mname();
sv.Value();
sv.Spec();
sv.Display();
sv.Get();
Console.WriteLine();

