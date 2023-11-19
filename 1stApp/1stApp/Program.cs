

string myName = "Ewa";
bool isWoman = true;
int myAge = 33;
char nameRecog = myName.Last();

//Sprawdzenie płci na podstawie imienia
if (nameRecog == 'a')
{
    isWoman = true;
    Console.WriteLine("Imię konćzy się na a więc to kobieta");
}
else
{
    isWoman = false;
    Console.WriteLine("Imię nie kończy się na a więc to mężczyzna");
}

if (isWoman == true)
{
    if (myAge < 30)
    {
        Console.WriteLine("Kobieta poniżej 30");
    }
    else if (myAge == 33 && myName == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (myAge < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}