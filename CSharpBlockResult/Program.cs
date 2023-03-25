Console.Clear();

Console.WriteLine("Введите массив строк, разделителем строк в нашем случае выступает (,) Как пример [\x0022hello\x0022, \x00222\x0022, \x0022world\x0022, \x0022:-)\x0022]  ");
string inputString = Console.ReadLine();
string[] newMassFromInputString = inputString.Trim(new char[] { '[', ']' })
                                            .Replace("\x0022", "")
                                            .Split(",", StringSplitOptions.RemoveEmptyEntries);

string result = "";

for (int i = 0; i < newMassFromInputString.Length; i++)
{
    if (newMassFromInputString[i].Length <= 3) result += newMassFromInputString[i] + ",";
}

string[] resultMas = result.Split(",", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("\n[" + string.Join(", ", resultMas) + "]");