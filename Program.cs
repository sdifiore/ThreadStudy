public class MainClass
{
    private const int REPETITIONS = 100;

    public static void DoWork()
    {
        for (int i = 0; i < REPETITIONS; i++)
        {
            Console.Write("B");
        }
    }

    public static void Main()
    {
        Thread t = new Thread(() =>
        {
            Console.WriteLine("Thread is starting, press ENTER to continue...");
            Console.ReadLine();
        });

        t.IsBackground = false;
        t.Start();
    }
}