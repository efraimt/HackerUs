/*
OR = +
1 + 1 =1
1 + 0 = 0 + 1 = 1
0 + 0 = 0
----------------
AND = *
0 * 0 = 0 * 1 = 1 * 0 = 0
1 * 1 = 1
*/

bool A = false;
bool B = true;

bool result = A || B;//false if A and B are false, else true
result = A && B; // if A and B are true => true , else false

if (A == true && B)
{


}

int yearsStuding = 1;
double average = 80.20;//hard coded
int summery = 2201;

bool isAverageAbove85 = average > 85;

//OR ELSE
if (isAverageAbove85 && summery > 2500 || Console.ReadLine() == "Moshe")
{
    Console.WriteLine("Free hour!!! YEEEEEEE!");
}

if ((isAverageAbove85 && summery > 2500) || Console.ReadLine() == "Moshe")
{
    Console.WriteLine("Free hour!!! YEEEEEEE!");
}

if (isAverageAbove85 && (summery > 2500 || Console.ReadLine() == "Moshe"))
{
    Console.WriteLine("Free hour!!! YEEEEEEE!");
}

if (yearsStuding > 2)
{
    if (isAverageAbove85 || summery > 2500)
    {
        Console.WriteLine("Free hour!!! YEEEEEEE!");
    }
    else if (average > 75)
    {
        Console.WriteLine("0.5 hour free");
        Console.WriteLine("YYYYYYYYEEEEEE");
    }
    else if (summery > 2000)
        Console.WriteLine("15 minutes");
}
else
{
    Console.WriteLine("Hakalot!!");
    if (average > 80 || summery > 2000)
        Console.WriteLine("Frree hour!!");
}


