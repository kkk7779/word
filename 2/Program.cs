static void Main(string[] args)
{
    int count = 0;
    int i, j;
    for (i = 101; i <= 200; i++)
    {
        for (j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                break;
            }
        }
        if (i == j)
        {
            count++;
            Console.WriteLine(i);
        }

    }
    Console.WriteLine("共" + count.ToString() + "个");
    Console.ReadLine();
}