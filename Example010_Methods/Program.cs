int[] array = { 12, 5, 65, 29, 40, 1, 76, 3, 40 };

int n = array.Length;
int find = 40;

int index = 0;

while (index < n)
{
    if (find == array[index])
    {
        Console.WriteLine(index);
        break;
    }
    index++;
    
}

