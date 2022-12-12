Console.Write("Введите массив данных через запятую(слова и/или целые числа): ");
string element = Console.ReadLine();
string[] array1 = element.Split(",");
string[] array2 = new string[0];

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        Array.Resize(ref array2, array2.Length + 1);
        array2[array2.Length - 1] = array1[i];
    }
}
Console.WriteLine($"{string.Join(", ", array2)}");