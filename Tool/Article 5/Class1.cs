class Program5
{
    static void Main5(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            var j = i;//Add
            Task.Run(() => Test5(j));
        }
        Console.Read();
    }

    static void Test5(int index)
    {
        //int a; init
        int a = 0;
        for (int i = 0; i < 1000000; i++)
        {
            a += i;
        }
        Console.WriteLine("Task number:" + index + " Complete");
    }
}
