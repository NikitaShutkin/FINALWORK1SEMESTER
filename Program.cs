


Console.Write("Введите элементы через пробел: ");
string[] M = Console.ReadLine().Split(' ');
string[] N = new string[M.Length];
int i = 0;
int j = 0;
int size = 0;
for (i = 0; i < M.Length; i++)
    Console.Write($"{M[i]} ");
Console.WriteLine();
for (i = 0; i < M.Length; i++)
    if (M[i].Length <= 3)
    {
        N[j] = M[i];
        j++;
        i++;
    }
    else i++;
size = j;
for (j = 0; j < size; j++)
    Console.Write($"{N[j]} ");
Console.WriteLine();

