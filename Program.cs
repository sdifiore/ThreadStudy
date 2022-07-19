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

    public static void DoWork2(char c)
    {
        for (int i = 0; i < REPETITIONS; i++)
        {
            Console.WriteLine(c);
        }
    }

    public static void Main()
    {
        Thread t2 = new Thread(() =>
        {
            DoWork2('B');
        });
        t2.Start();

        DoWork2('A');
    }
}