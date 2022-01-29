long n = 10000;
bool[] b = new bool[n];
for (long i = 2; i < n; i++)
    b[i] = true;
for (long i = 2; i * i < n; i++)
{
    if ((b[i]))
    {
        for (long j = 2 * i; j < n; j += i)
        {
            b[j] = false;
        }
    }
}
for (long i = 2; i < n; i++)
{
    if (b[i])
        Console.WriteLine("{0}\n", i.ToString());
}