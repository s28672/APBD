Console.WriteLine("Hello, World!");


static double CalculateAverage(int[] arr) {
    int plus = 0;
    foreach(var a in arr)
    {
        plus += a;
    }
    return plus / arr.Length;
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