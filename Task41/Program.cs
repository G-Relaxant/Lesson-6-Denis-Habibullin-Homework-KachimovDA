// Мой вариант

Console.Write("Input numbers: ");
string input  = Console.ReadLine();
Console.WriteLine("Inputed data: " + input);
int countNumbers = 1;
for(int i = 0; i < input.Length; i++)
{
    if(input[i] == ',')
    {
        countNumbers++;
    }
}
Console.WriteLine("Count of numbers: " + countNumbers);
int[] array = new int[countNumbers];
string bufer = string.Empty;
int j = 0;
for(int i = 0; i < input.Length; i++)
{
    while(input[i] != ',' && i != input.Length)  // Второе условие не выполняется и индекс уходит в зашкал с вылетом ошибки(если без if(break))
    {
        bufer = bufer + input[i].ToString();
        Console.WriteLine("Bufer: " + bufer);
        i++;
        if(i == input.Length) // Необходимо, чтобы принудительно завершить цикл после достижения максимального индекса
        {
            break;
        }
    }
    array[j] = Convert.ToInt32(bufer);                      //\
    Console.WriteLine("Array[j] value: " + array[j]);       // \
    j++;                                                    //  } ЭТА ЧАСТЬ КОДА НЕ ВЫПОЛНЯЕТСЯ НА ПОСЛЕДНЕМ ВИТКЕ ЦИКЛА 'while' И ПРОГА КРАШИТСЯ, без прерывателя if(break),
    bufer = string.Empty;                                   // /  то есть второе условие после && не выполняется
}
PrintArray(array);
int counter = 0;
for(int i =0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        counter++;
    }
}
Console.Write("Answer: " + counter);


void PrintArray(int[] b)
{
    Console.Write("[");
    for(int i = 0; i < b.Length; i++)
    {
        Console.Write(b[i]);
        if(i < b.Length - 1)
            Console.Write(", ");
        else
            Console.WriteLine("]");
    }
}





// Вариант из 7 семинара
/*
Console.Write("Input numbers: ");
string input  = Console.ReadLine();
Console.WriteLine("Input data: " + input);
int countNumbers = 1;
for(int i = 0; i < input.Length; i++)
{
    if(input[i] == ',')
    {
        countNumbers++;
    }
}
Console.WriteLine("Count of numbers: " + countNumbers);
int[] array = new int[countNumbers];
int index = 0;
string bufer = string.Empty;
for(int i = 0; i < input.Length; i++)
{
    while(input[i] != ',')
    {
        if(i != input.Length - 1)
        {
            bufer += input[i].ToString();
            i++;
        }
        else
        {
            bufer += input[i].ToString();
            break;
        }
        Console.WriteLine("Bufer: " + bufer);
    }
    array[index] = Convert.ToInt32(bufer);
    index++;
    bufer = string.Empty;
}
PrintArray(array);
int counter = 0;
for(int i =0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        counter++;
    }
}
Console.Write("Answer: " + counter);


void PrintArray(int[] b)
{
    Console.Write("[");
    for(int i = 0; i < b.Length; i++)
    {
        Console.Write(b[i]);
        if(i < b.Length - 1)
            Console.Write(", ");
        else
            Console.WriteLine("]");
    }
}
*/
