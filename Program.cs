public class MainClass
{
    private const int REPETITIONS = 1_000;

    public static void DoWork(object obj)
    {
        char c = (char)obj;
        for (int i = 0; i < REPETITIONS; i++)
        {
            Console.WriteLine(c);
        }
    }

    public static void DoWork2(object obj)
    {
        char c = (char)obj;
        for (int i = 0; i < REPETITIONS; i++)
        {
            Console.WriteLine(c);
        }
    }

    public static void Main()
    {
        Thread t1 = new Thread(DoWork);
        t1.Start('B');

        DoWork('A');
    }
}