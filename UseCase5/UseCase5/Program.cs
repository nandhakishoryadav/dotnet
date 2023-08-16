using System.Drawing;
using UseCase5;

Colour colorinfo1 = new Colour
{

    Name = "RED ",
    Code = "100"
};


Colour colorinfo2 = new Colour
{

    Name = "WHITE ",
    Code = "200"
};


Engine engineinfo1 = new Engine
{
    Type = "V12",
    Power = "1000 CC"
};

Engine engineinfo2 = new Engine
{
    Type = "V8",
    Power = "1500 CC"
};

Car car1 = new Car
{
    Make = "BMW",
    Model = "5 Series",
    Year = 2020,
    engineinfo = engineinfo1,
    colorinfo = colorinfo1
};

Car car2 = new Car
{
    Make = "PORSCHE",
    Model = "CARRERA",
    Year = 2021,
    engineinfo = engineinfo2,
    colorinfo = colorinfo2
};

car1.DisplayCarInformation();
Console.WriteLine();
car2.DisplayCarInformation();


