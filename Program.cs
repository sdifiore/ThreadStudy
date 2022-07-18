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
        for (int i = 0; i < 9; i++)
        {
            Thread t = new Thread(DoWork);
            t.Name = $"Thread {i}";
            t.Start();
        }

        int dummy = 123;
    }
}