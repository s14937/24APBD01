// See https://aka.ms/new-console-template for more information

Console.WriteLine("aww yeah");

static double avg(int[] ints)
{
    int sum = 0;
    for (int i = 0;i<ints.Length;i++)
    {
        sum += ints[i];
    }

    return (sum / Convert.ToDouble(ints.Length));
}

int[]tabliczka ={0,100,0};

Console.WriteLine(avg(tabliczka));