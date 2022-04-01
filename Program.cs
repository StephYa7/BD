using static System.Console;


string[] startString = new string[] {"hell22o", "tth", "1125", "123", "jaja0", "123", "0000", "12s"};
int newLenght = 0;


for (int i = 0; i < startString.Length; i++)
{
    if (startString[i].Length <= 3)
    {
        newLenght += 1;
    }

}

string[] newString = new string[newLenght];
int index = 0
;

for (int a = 0; a < newLenght; a++)
{
    if (startString[a].Length <= 3)
    {
        newString[index] = startString[a];

        index ++;
    }
}

WriteLine(string.Join(",", startString));
WriteLine(startString[0]);
WriteLine(newLenght);
WriteLine(string.Join(",", newString));
WriteLine(newString[0]);