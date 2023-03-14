namespace HomeTask12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var player = new Player();

            player.Play();
            player.Pause();
            player.Stop();

            Console.WriteLine();

            player.Record();
            player.Pause();
            player.Stop();
        }
    }
}