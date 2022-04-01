using static System.Console;


string[] startString = new string[] {"hel", "tth", "1125", "12423", "jaj", "123", "00550", "12s"};
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

for (int i = 0; i < startString.Length; i++)
{
    if (startString[i].Length <= 3)
    {
        newString[index] = startString[i];

        index ++;
    }
}

WriteLine(string.Join(",", startString));

WriteLine(string.Join(",", newString));
