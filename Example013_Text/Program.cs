// задача 1 Дан текст. В тексте нужно заменить все пробелы черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "Как дела сегодня?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] = oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }


    return result;
}

string newText = Replace(text, ' ', '-');
Console.WriteLine (newText);
