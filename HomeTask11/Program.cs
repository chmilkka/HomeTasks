namespace HomeTask11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classRoom = new ClassRoom();
            for (int i = 0; i < classRoom.pupils.Length; i++)
            {
                classRoom.pupils[i].Study();
                classRoom.pupils[i].Read();
                classRoom.pupils[i].Write();
                classRoom.pupils[i].Relax();
                Console.WriteLine();
            }
        }
    }
}