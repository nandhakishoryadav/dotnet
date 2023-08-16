
using UsecaseStaticSample1;

Person person1 = new Person();
person1.Name = "Anu";
person1.Age = 19;
person1.Job = "teacher";
person1.SnacksBought = 1;
person1.SnackRefilled = 0;
person1.BuySnacks();
person1.CheckRemainingInventory();

Console.WriteLine();

Person person2 = new Person();
person2.Name = "Bindu";
person2.Age = 19;
person2.Job = "teacher";
person2.SnackRefilled = 20;
person2.SnacksBought = 0;
person2.RefillInventory();
person2.CheckRemainingInventory();






