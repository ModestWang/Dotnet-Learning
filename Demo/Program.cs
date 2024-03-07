internal class Program
{
    private static void Main(string[] args)
    {
        //线程
        //Thread t = Thread.CurrentThread;
        //t.Name = "Main Thread";
        //Console.WriteLine(t.Name);
        Thread childThread = new Thread(new ThreadStart(ChildThreadMethod));
        childThread.Start();

        Console.WriteLine("Main Thread");
        Thread.Sleep(2000);
        isRun = false;

        //childThread.Abort(); //强制终止线程
    }

    private static bool isRun = true;

    private static void ChildThreadMethod()
    {
        while (isRun)
        {
            Console.WriteLine("Child Thread");
            Thread.Sleep(1000);
        }
    }
}
