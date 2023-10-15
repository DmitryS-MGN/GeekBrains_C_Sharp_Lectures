Цикл в цикле для таблицы умножения.
for (int i = 2; i <= 9; i++)
{
    for (int j = 2; j <= 9; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine();
}


//Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.

//— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?

// string s = "qwerty" - строка и ее символы.
//             012345  - номер символа строки.
// s[3]           - чтобы получить конкретный символ строки, его номер указываем в квадратных скобках, после идентификатора строки.  


string text = "Я думаю, — сказал князь, улыбаясь, — что,"
                + "ежели бы вас послали вместо нашего милого Винценгероде"
                + ",вы бы взяли приступом согласие прусского короля."
                + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length; // text.Length - длина строки или количество символов в строке.
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else 
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}
string newText = Replace(text,  ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(text,  'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(text,  'c', 'C');
System.Console.WriteLine(newText);

//Упорядочить массив от от меньшего к большему.
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void printArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void selectionSort(int[] array)

{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

printArray(arr);
selectionSort(arr);
printArray(arr);