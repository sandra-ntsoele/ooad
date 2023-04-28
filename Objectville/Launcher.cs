namespace Objectville
{
    class Launcher
    {
        public Launcher() 
        {
            // Set speed, without encapsulation
            Jet jet1 = new Jet();
            jet1.Speed = 212;
            Console.WriteLine($"Jet 1 Speed: {jet1.Speed}");

            // Set speed, with encapsulation
            Jet jet2 = new Jet();
            jet2.SetSpeed(212);
            Console.WriteLine($"Jet 2 Speed: {jet2.GetSpeed()}");
        }
    }
}