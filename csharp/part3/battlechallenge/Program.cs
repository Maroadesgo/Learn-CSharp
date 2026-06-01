Random random = new Random();

int heroHealth = 10;
int monsterHealth = 10;

do
{
	int attack = random.Next(1,10);

	monsterHealth -= attack;
	Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth}");

	if(monsterHealth <= 0) continue;

	attack = random.Next(1,10);	
	heroHealth -= attack;
	Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth}");
}
while(heroHealth > 0 &&  monsterHealth > 0);

Console.WriteLine(monsterHealth > heroHealth ? "Monster WIN" : "Hero WIN");
