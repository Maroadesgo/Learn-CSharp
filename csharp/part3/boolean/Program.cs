Random coin = new Random();
int flip = coin.Next(1,3);
Console.WriteLine($"Flip: {(flip == 1 ? "Heads" : "Tails")}");
/*
int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Console.WriteLine("a"!= "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

string value1 = " a";
string value2 = "A ";

Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >=2);
Console.WriteLine(1 <= 2);

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine($"{pangram}\n");
Console.WriteLine($"contains fox? {pangram.Contains("fox")}");
Console.WriteLine(pangram.Contains("cow"));

//negacion logica
Console.WriteLine($" Contains fox? {!pangram.Contains("fox")}");
*/
