Console.WriteLine("Hello, World!");


static double CalculateAverage(int[] arr) {
    int sum = 0;
    foreach(var b in arr)
    {
        sum += b;
    }
    return sum / arr.Length;
}

static int FindMax(int[] arr)
{
    int max = 0;
    foreach (var i in arr)
    {
        if (i > max) { 
            max = i;
        }
    }
    return max;
}