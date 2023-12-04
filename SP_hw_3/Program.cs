
class Program
{
   
    static int length = 4;
    private static int count;

    static void CountCount()
    {
        for (int i = 0; i < 100000; i++)
        {
            count++;
        }

    }
    static void Main(string[] args)
    
    {
        Thread[] threads = new Thread[length];


        for (int i = 0; i < length; i++)
        {
            threads[i] = new Thread(CountCount);
            threads[i].Start();
        }
        Console.WriteLine(count);
        
    }
}
