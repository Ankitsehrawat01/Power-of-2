Console.WriteLine("Program to find 2 power till 31");
int N = 0;
while (N < 31)
{
    N++;
    long power = (long)Convert.ToInt64(Math.Pow(2, N));
    Console.WriteLine("The result of is : " + power);
}