string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;

foreach (string myString in myStrings)
{
    string current = myString; // ← Variable local que sí podemos modificar

    periodLocation = current.IndexOf(".");

    while (periodLocation != -1)
    {
        string sentence = current.Substring(0, periodLocation);
        sentence = sentence.TrimStart();
        Console.WriteLine(sentence);
        current = current.Remove(0, periodLocation + 1); // ← Usamos current, no myString
        periodLocation = current.IndexOf(".");            // ← Usamos current, no myString
    }

    Console.WriteLine(current.TrimStart());
}
/*
//VALIDATE STRING INPUT
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

string? role;
bool validRole = true;
do
{
	role = Console.ReadLine();
	role.Trim();
	role.ToLower();
	if (validRole != null)
		if (role != "Administrator" && role != "Manager" && role != "User" )
			Console.WriteLine($"The role name that you enterd, {role} is no valid. Enter your role name (Administrator, Manager, or User)");

}while(role != "Administrator" && role != "Manager" && role != "User");

Console.WriteLine($"Your input value {role} has been accepted");

//VALIDATE INTEGER INPUT

string? numberEnter;
int number = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5  and 10");

do
{
	numberEnter = Console.ReadLine();
	validNumber = int.TryParse(numberEnter, out number);
	if(validNumber == false)
		Console.WriteLine("Sorry, you enter an invalid number, please try again.");
	else if (number < 5 || number > 10)
		Console.WriteLine($"you entered {number}, please enter a number between 5 and 10.");
}while(number < 5 || number > 11);
Console.WriteLine($"You input values ({number}) has been accepted");
*/

/*
Random random = new Random();
int current = random.Next(1, 11);
int hero = 10;
int monster = 10;
//DESAFIO 1
do
{

	
	current = random.Next(1, 11);
	monster -= current;
	Console.WriteLine($"Monster was damaged and lost {current} health and now has {monster} health."); 
	
	if (monster <= 0) continue;

	current = random.Next(1, 11);
	hero -= current;
	Console.WriteLine($"Hero was damaged and lost {current} health and now has {hero} health.");
}
while(hero > 0 && monster >0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster Wins!");

do
{
	current = random.Next(1, 11);

	if (current >= 8 ) continue;
	
	Console.WriteLine(current);

}while(current != 7);


while(current >= 3)
{
	Console.WriteLine(current);
	current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");


do
{
	current = random.Next(1,11);
	Console.WriteLine(current);
}
while (current != 7);
*/
