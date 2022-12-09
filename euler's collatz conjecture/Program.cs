using System;

int highscore = 0;
ulong num = 1;

while (true)
{
    ulong n = num;
    List<ulong> list = new List<ulong>();

    while (true)
    {
        if (n % 2 == 0) // even
        {
            ulong x = n / 2;
            n = x;
            list.Add(x);
            if (n == 1)
                break;
        }
        else // odd
        {
            ulong y = (3 * n) + 1;
            n = y;
            list.Add(y);
            if (n == 1)
                break;
        }
    }


    if (list.Count > highscore)
    {
        Console.Clear();
        highscore = list.Count;
        

        Console.WriteLine($"\nThe number: {num} highscore {highscore} gave me:\n");
        foreach(ulong number in list)
        {
            Console.Write(number + " ");
        }

        
    }

    num++;
}
