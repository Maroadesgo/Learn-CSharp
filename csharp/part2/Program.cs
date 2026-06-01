//COMENTARIO

/*
this code conver the message into a char array and reverse the chars
count the o's and convert it back to a sting
print it out
*/
string message =  "The quick brown fox jumps over the lazy dog.";
char[] charMessage = message.ToCharArray();
Array.Reverse(charMessage);
int count = 0;
foreach (char i in charMessage)
{
	if (i == 'o')
	{
		count++;
	}
}
string newMessage = new String(charMessage);
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {count} times.");

/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
  if((roll1 == roll2) && (roll2 == roll3))
  {
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
  }
  else
  {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total +=2;
  }
}

Random random = new Random();
string[] orderIDs = new string[10];
//Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
	//Get a random value that equates to ASCII letters A Through E
	int prefixValue = random.Next(65,70);
	//Convert the random value into a char, then a string
	string  prefix = Convert.ToChar(prefixValue).ToString();
	//Create a random number, pad with zeroes
	string suffix = random.Next(1, 1000).ToString("000");
	orderIDs[i] = prefix + suffix;
}
//print out each orderID
foreach (var orderID in orderIDs)
{
	Console.WriteLine(orderID);
}

string firstName = "Bob";
int widgetsPurchased = 7;
//int widgetsSold = 7;
//Testing a change to the message.
//int widgetsSold = 7;
//Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
string[] fraudulentOrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach(string fraudulentOrder in fraudulentOrderIDs)
{
	if(fraudulentOrder.StartsWith("B"))
	{
		Console.WriteLine($"fraudulentOrderIDs: {fraudulentOrder}");
	}
}

int[] inventory = {200, 450, 700, 175, 250};

int sum = 0;

int bin = 0;

foreach(int items in inventory)
{
	sum += items;
	bin ++;
	Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

string[] names = {"Rowena", "Robin", "Bao"};

foreach (string name in names)
{
	Console.WriteLine(name);
}


string[] fraudulentOrderIDs = ["A034", "B056", "C078"]; 

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
///fraudulentOrderIDs[3] = "D012";
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F034";
Console.WriteLine($"Reassign  First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
	if (daysUntilExpiration <= 5)
	{
		Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
		discountPercentage = 10;
	}
	else
	{
		Console.WriteLine("Your subscription will expire soon. Renew now!");
	}
}
else if (daysUntilExpiration == 1)
{
	Console.WriteLine("You subscription expires within a day!");
	discountPercentage = 20;
	
}
else
{
	Console.WriteLine("You subcription has expired");
}

if (discountPercentage > 0 )
{
	Console.WriteLine($"Renew now and save {discountPercentage = 10}%.");
}
//Your code goes here

//Logica

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


if ((roll1 == roll2) || (roll2 ==roll3) || (roll1 == roll3))
{
	if ((roll1==roll2) && (roll2 == roll3))
	{
		Console.WriteLine("You rolled triples! +6 bonus to total!");
		total +=6;
	}
	else
	{
		Console.WriteLine("You rolled double! +2 bonus to total!");
		total +=2;
	}
	Console.WriteLine($"You total including the bonus: {total}");
} 
if (total >= 16)
{
	Console.WriteLine("You win a new car!!");
}
else if (total >= 10)
{
	Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
	Console.WriteLine("You win a new trip for two!");
}
else
{
	Console.WriteLine("You win a kitten!");
}

//******************
//EXPRESION BOOLEANA

string message = "The quick borwn fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
	Console.WriteLine("What does the fox say?");
}
*/

