using Stack1;

class Program
{
    // Реализовать стек или очередь с использованием
    // массива фиксированной длины
    
    static void Main()
    {
        try
        {
            FixedStack<string> songs = new FixedStack<string>(3);
            songs.Push("The Above");
            songs.Push("Circle Through");
            Console.WriteLine(songs.Peek());
            songs.Push("A Drone Opting Out Of The Hive");
            Console.WriteLine(songs.Peek());
            songs.Push("I Fly");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}