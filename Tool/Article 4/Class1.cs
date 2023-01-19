class Program4
{
    //Review the code below and tell us what’s a final result and why?.
    static void test2(string[] args)
    {
        Thread thread1 = new(Get);
        Thread thread2 = new(Get);
        thread1.Start("A:");
        thread2.Start("B:");
        Console.Read();
    }

    static void Get(object prefix)
    {
        string pre = (string)prefix;
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(50);
            Console.WriteLine(pre + i);
        }
    }
}
