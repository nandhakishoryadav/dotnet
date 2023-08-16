using UsecaseStatic;

People people1 = new People();
people1.Name = "James";
people1.Age = 25;
people1.Job = "doctor";
people1.SnacksBought = 1;
people1.SnacksRefilled = 0;
people1.Pname();
people1.Buysnacks();
people1.Checktheremaininginventory();

Console.WriteLine();

People people2 = new People();
people2.Name = "George";
people2.Age = 25;
people2.Job = "Engineer";
people2.SnacksBought = 0;
people2.SnacksRefilled = 50;
people2.Pname();
people2.Refilltheinventory();
people2.Checktheremaininginventory();