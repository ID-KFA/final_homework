// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] words = { "hello", "167", ":-)", "geek", "гик" };
string[] ShortWords = new string[0];
int length = 3;

void PrintArray(string[] array)

{
string s = string.Join(", ", array);
Console.WriteLine(s);
}

void MakeNewArray(string[] array, int length)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            ShortWords = ShortWords.Concat(new string[] { array[i] }).ToArray();
        }

    }
}




Console.Clear();

Console.Write("Задан массив: ");
PrintArray(words);
Console.WriteLine();
MakeNewArray(words, length);
Console.Write($"Сформирован массив из коротких слов, длиной не более {length} символов: ");
PrintArray(ShortWords);
Console.WriteLine();