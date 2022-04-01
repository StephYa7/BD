using static System.Console;


string[] startString = new string[] {"hell22o", "tt", "123", "1234", "jaja0", "s"};
int newLenght = 0;


for (int i = 0; i < startString.Length; i++)
{
    if (startString[i].Length <= 3)
    {
        newLenght += 1;
    }

}



WriteLine(string.Join(",", startString));
WriteLine(startString[0].Length);
WriteLine(newLenght);