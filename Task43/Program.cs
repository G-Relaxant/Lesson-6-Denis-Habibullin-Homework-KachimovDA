int b1 = InputData("Введите число b1: ");
int k1 = InputData("Введите число k1: ");
int b2 = InputData("Введите число b2: ");
int k2 = InputData("Введите число k2: ");
double x1 = 0;
double x2 = 0;
double y1 = k1 * x1 + b1;
double y2 = k2 * x2 + b2;
double y1Test = k1 * 0.1 + b1;
double y2Test = k2 * 0.1 + b2;
double div1 = y1 - y2;
double div2 = y1Test - y2Test;
if(div1 < 0)
{
    div1 = div1 * -1;
}
if(div2 < 0)
{
    div2 = div2 * -1;
}
if(y1 == y2)
{
    Console.WriteLine("Точка пересечения прямых на координате: (" + x1 + "; " + y1 + ")");
}
else
{
    if(div1 < div2)
    {  
        if(y1 < y2)
        {
            while(y1 < y2)
            {
                x1 = x1 - 0.1;
                x2 = x2 - 0.1;
                y1 = k1 * x1 + b1;
                y2 = k2 * x2 + b2;
            }
        }
        else
        {
            while(y1 > y2)
            {
                x1 = x1 - 0.1;
                x2 = x2 - 0.1;
                y1 = k1 * x1 + b1;
                y2 = k2 * x2 + b2;
            }
        }
        Console.WriteLine("Точка пересечения прямых на координате: (" + x1 + "; " + y1 + ")");
    }
    if(div1 > div2)
    {
        if(y1 < y2)
        {
            while(y1 < y2)
            {
                x1 = x1 + 0.1;
                x2 = x2 + 0.1;
                y1 = k1 * x1 + b1;
                y2 = k2 * x2 + b2;
            }
        }
        else
        {
            while(y1 > y2)
            {
                x1 = x1 + 0.1;
                x2 = x2 + 0.1;
                y1 = k1 * x1 + b1;
                y2 = k2 * x2 + b2;
            }
        }
        Console.WriteLine("Точка пересечения прямых на координате: (" + x1 + "; " + y1 + ")");
    }
}


int InputData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}