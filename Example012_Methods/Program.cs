// Вид 1 (не принимают аргументы и не возвращают ничего)
void Method1()
{
    Console.WriteLine("Автор...");
}
/// как вызвать методы первого типа
Method1();



// Вид 2 (принимают аргументы и ничего не возвращают)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// как вызвать такой метод
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);




// Вид 3 (что-то возвращают, но ничего не принимают)
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


// вид 4 (что-то принимают и возвращают)
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (1 < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "млвт");
Console.WriteLine(res);

// Цикл for вместо while

string Method4(int count, string c)
{

    string result = String.Empty;
    for(int = 0; i < count; i++)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "млвт");
Console.WriteLine(res);


// использование цикла в цикле (например, вывод таблицы умножения на экран)

for(int i = 2; i <= 10 i++)
{
    for (int) j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}



