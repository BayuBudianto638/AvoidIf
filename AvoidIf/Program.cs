var a = new int[] { 1, 2, 3, 4, 5 };

var foundInt = a.FirstOrDefault(w => w == 4);

Console.WriteLine($"{foundInt.ToString()}");
Console.ReadKey();

string monthName = "Juni";

var tableMonth = new string[] { "Bulan", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
var listMonth = tableMonth.ToList();
int month = listMonth.IndexOf(monthName);
Console.WriteLine($"{month.ToString()}");
Console.ReadKey();