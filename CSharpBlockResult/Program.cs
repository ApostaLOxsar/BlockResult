//

Console.WriteLine("Введите массив строк, разделителем строк в нашем случае выступает (,) Как пример [hello, 2, world, :-)] ");
string inputString = Console.ReadLine();
string[] newMassFromInputString = inputString.Split(", ", StringSplitOptions.RemoveEmptyEntries);

string result = "";

for (int i = 0; i < newMassFromInputString.Length; i++)
{
    if (newMassFromInputString[i].Length <= 3)  result += newMassFromInputString[i] + ",";
    
}


string[] resultMas = result.Split(",", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("[" + string.Join(", ", resultMas) + "]");
