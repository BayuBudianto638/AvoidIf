var a = new int[] { 1, 2, 3, 4, 5 };

var foundInt = a.FirstOrDefault(w => w == 4);

Console.WriteLine($"{foundInt.ToString()}");
Console.ReadKey();
