int b1 = InputData("Введите число b1: ");
int k1 = InputData("Введите число k1: ");
int b2 = InputData("Введите число b2: ");
int k2 = InputData("Введите число k2: ");
double x1 = 0;
double x2 = 0;
double x1ParallelCheck = k1 * (x1 + 1);
double x2ParallelCheck = k2 * (x2 + 1);
double y1 = k1 * x1 + b1;
double y2 = k2 * x2 + b2;
double y1ReduceDifferenceCheck = k1 * 0.1 + b1;
double y2ReduceDifferenceCheck = k2 * 0.1 + b2;
double div1 = y1 - y2;
double div2 = y1ReduceDifferenceCheck - y2ReduceDifferenceCheck;
double calculateStep = 1;
int calculateStepsCount = 6;

if(div1 < 0)
{
    div1 = div1 * -1;
}
if(div2 < 0)
{
    div2 = div2 * -1;
}

if(x1ParallelCheck == x2ParallelCheck)
{
    Console.WriteLine("Вы задали параллельные прямые");
}
else
{
    if(div1 < div2)
    {  
        if(y1 < y2)
        {
            for(int i = 0; i < calculateStepsCount; i++)
            {
                while(y1 < y2)
                {
                    x1 = x1 - calculateStep;
                    x2 = x2 - calculateStep;
                    y1 = k1 * x1 + b1;
                    y2 = k2 * x2 + b2;
                }
                if(i != calculateStepsCount)
                {
                    x1 = x1 + calculateStep;
                    x2 = x2 + calculateStep;
                    y1 = k1 * x1 + b1;
                    y2 = k2 * x2 + b2;
                    calculateStep = calculateStep / 10;
                }
            }    
        }
        else
        {
            for(int i = 0; i < calculateStepsCount; i++)
            {
                while(y1 > y2)
                {
                    x1 = x1 - calculateStep;
                    x2 = x2 - calculateStep;
                    y1 = k1 * x1 + b1;
                    y2 = k2 * x2 + b2;
                }
                if(i != calculateStepsCount)
                {
                    x1 = x1 + calculateStep;
                    x2 = x2 + calculateStep;
                    y1 = k1 * x1 + b1;
                    y2 = k2 * x2 + b2;
                    calculateStep = calculateStep / 10;
                }
            }
        }
        double xAns = Approximate(x1);
        double yAns = Approximate(y1);
        Console.WriteLine("Точка пересечения прямых на координате: (" + xAns + "; " + yAns + ")");
    }
    if(div1 > div2)
    {
        if(y1 < y2)
        {
            for(int i = 0; i < calculateStepsCount; i++)
            {
                while(y1 < y2)
                {
                    x1 = x1 + calculateStep;
                    x2 = x2 + calculateStep;
                    y1 = k1 * x1 + b1;
                    y2 = k2 * x2 + b2;
                }
                if(i != calculateStepsCount)
                {
                    x1 = x1 - calculateStep;
                    x2 = x2 - calculateStep;
                    y1 = k1 * x1 + b1;
                    y2 = k2 * x2 + b2;
                    calculateStep = calculateStep / 10;
                }
            } 
        }
        else
        {
            for(int i = 0; i < calculateStepsCount; i++)
            {
                while(y1 > y2)
                {
                    x1 = x1 + calculateStep;
                    x2 = x2 + calculateStep;
                    y1 = k1 * x1 + b1;
                    y2 = k2 * x2 + b2;
                }
                if(i != calculateStepsCount)
                {
                    x1 = x1 - calculateStep;
                    x2 = x2 - calculateStep;
                    y1 = k1 * x1 + b1;
                    y2 = k2 * x2 + b2;
                    calculateStep = calculateStep / 10;
                }
            }
        }
        double xAns = Approximate(x1);
        double yAns = Approximate(y1);
        Console.WriteLine("Точка пересечения прямых на координате: (" + xAns + "; " + yAns + ")");
    }
}

//double xAns = Approximate(x1);
//double yAns = Approximate(y1);
//Console.WriteLine("Точка пересечения прямых на координате: (" + xAns + "; " + yAns + ")");

int InputData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

double Approximate(double a)
{
    a = Math.Round(a, 3);
    return a;
}