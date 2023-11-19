long number = 99010233040560678;
string numberInString = number.ToString();
char[] chars = numberInString.ToCharArray();

Console.WriteLine("Wynik dla liczby: " + number);
for (int i = 0; i < 10; i++)
{
    int counter = 0;
    foreach (char c in chars)
    {
        string iStr = i.ToString();
        string cStr = c.ToString();
        if (cStr == iStr)
        {
            counter++;
        }
    }
    Console.WriteLine(i + " => " + counter);
}

