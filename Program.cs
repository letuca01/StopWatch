namespace StopWatch
{
    class program
    {
        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = second => 1s => 1 second");
            Console.WriteLine("M = minute => 1m => 1 minute");
            Console.WriteLine("0 - exit");
            Console.WriteLine("How much time you wanna count?");

            string data = Console.ReadLine().ToLower(); // will convert everything to lowercase letters
            char type = char.Parse(data.Substring(data.Length-1, 1)); // picking the last element
            int time = int.Parse(data.Substring(0,data.Length-1)); // all the elements except the last one
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;
            if(time == 0)
                System.Environment.Exit(0); // leaving the code
            
            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Read...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!");
            Thread.Sleep(2000);
            
            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;
            
            while (currentTime != time)
            {
                Console.Clear(); // to show only the result instead of all numbers until the result
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); // counting
            }
            Console.Clear();
            Console.WriteLine("StopWatch finished");
            Thread.Sleep(2500);
            Menu();
        }
    }
}