public class MainClass
{
    public static int i = 0;

    public static void DoWork()
    {
        for (i = 0; i < 5; i++)
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