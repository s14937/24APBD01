// See https://aka.ms/new-console-template for more information

Console.WriteLine("aww yeah");

static double avg(int[] ints)
{
    int sum = 0;

    for (int z = 0;z<ints.Length;z++)
    {
        sum += ints[z];
    }

    return (sum / Convert.ToDouble(ints.Length));
}

int[]tabliczka ={0,100,0};

Console.WriteLine(avg(tabliczka));

static int max(int[] ints)
{
    int maxval = ints[0];
    for (int i = 1; i < ints.Length; i++)
    {
        if (ints[i] > maxval)
        {
            maxval = ints[i];
        }
    }
    return maxval;
}

int[] tab2 = {3,6,9,12,11,8,5,2};
Console.WriteLine(max(tab2));