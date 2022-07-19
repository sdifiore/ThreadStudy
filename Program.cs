public class MainClass
{
    private const int REPETITIONS = 100;

    public static void DoWork()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{i} *");
        }
    }

    public static void Main()
    {
        Thread t = new Thread(DoWork);
        t.Start();

        DoWork();
    }
}