using System;
using System.Threading;

class Program
{
    static string ukrainianAlphabet = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
    static void Main()
    {
        Thread thread = new Thread(new ThreadStart(() => Worker()));
        thread.Start();
        thread.Join();
    }

    static void Worker()
    {
        int freq = 37, dura = 500;
        for (int i = 0; i < 10; i++)
        {
            generateSoundAndSleep(freq, 500, 500);
            freq *= 2;
            dura += 50;
        }
    }

    static void generateSoundAndSleep(int freq, int dura, int sleep)
    {
        Console.Beep(freq, dura);
        Thread.Sleep(sleep);
    }
}
