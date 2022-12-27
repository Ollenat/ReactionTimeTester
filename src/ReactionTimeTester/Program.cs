namespace ReactionTimeTester;
class Program
{
    static void Main(string[] args)
    {
        //Introduce player
        Console.WriteLine($"When you see the word 'NOW!' press [any key], then you'll see how fast you reacted!");
        Console.ReadLine();

        //Randomize wait time in milli seconds
        Random random = new Random(Environment.TickCount);
        int waitTime = random.Next(3000, 10000);
        
        //Alert player
        Console.WriteLine("Ok, get ready...");

        //Check Timer
        int beginning = Environment.TickCount;
        while (Environment.TickCount < beginning + waitTime)
        {
            //Check if key is pressed before time
            if (Console.KeyAvailable)
            {
                Console.WriteLine("Du fuskar!");
                Environment.Exit(0);
            }
        }

        //Write
        Console.WriteLine("NOW!");

        //Time from when awoken
        GapTimer timer = new GapTimer();

        //yield until a key is pressed
        Console.ReadKey(true);

        //Get reacted time
        int reactTime = timer.Time();

        //Write Results
        Console.WriteLine($"\nDet tog {reactTime} millisekunder för dig att reagera! \nSnyggt jobbat!");
    }
}
