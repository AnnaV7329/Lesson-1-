int[] array = {1,62,73,44,52,76,47,38};

int n = array.Length;
int find = 38;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index +1;
    index++;
}