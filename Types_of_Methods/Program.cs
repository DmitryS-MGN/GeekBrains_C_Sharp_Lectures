// 1) Группа методов, которые ничего не возвращают и ничего не принимают.
void Method1()
{
    System.Console.WriteLine("Автор....."); //То что происходит внутри метода.
}
Method1(); // Вызов метода, обязательно использование скобочек.

// 2) Группа методов,  которые ничего не возвращают, но принимают какие-то аргументы.
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2("Текст сообщения ");

void Method21(string msg, int count) //int count - именнованный аргумент(дополнительный) счетчик.
{
    int i = 0;
    while(i < count) 
    {
        System.Console.WriteLine(msg);
        i++; // Увеличение счетчика на еденицу, называют инкриментом, а уменьшение счетика на еденицу называют тэкриментом. 
                    //  !!!Если программу зацыклило, выбраться из зацикливания можно, при помощи сочетания клавиш Ctrl + C. 
    }
}
Method21("Текст сообщения ", 10);
Method21(count 5, "Текст сообщения ") // Соблюдение порядка ввода оргументов не обязательно. 

// 3) Группа методов, которые  что-то возвращают, но ничего не принимают.
int Method3() // Если метод, что-то возвращает, мы обязательно должны указать тип данных, например "int".
{
    return DateTime.Now.Year; //Метод обязательно должен возвращать какое-то значение.
}

int year = Method3(); // В int year будет положен результат работы метода
{
    System.Console.WriteLine(year);
}


// 4) Группа методов, которые что-то принимают и что-то возвращают.
string Method4(int count, string text) // char - символ
{
    int i = 0;
    string result = String.Empty; //Переменная куда кладется конечный результат. String.Empty - пустая строка.

    while(i < count) // Пример цикла, работающий через while
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf  ");
System.Console.WriteLine(res);


string Method4(int count, string text) 
{   
    string result = String.Empty;
    for(int i = 0; i < count; i++) // // Пример цикла, работающий через for.
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf  ");
System.Console.WriteLine(res);
