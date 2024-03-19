Console.WriteLine("Hello, World!");


static double CalculateAverage(int[] arr) {
    int sum = 0;
    foreach(var a in arr)
    {
        sum += a;
    }
    return sum / arr.Length;
}
