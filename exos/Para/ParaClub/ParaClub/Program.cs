namespace ParaClub
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;
            Console.CursorVisible = Config.CursonVisible;

            Plane plane = new Plane();
            plane.draw();

            //Console.ReadLine();

            while (true)
            {
                plane.update();

                // Temporiser
                Thread.Sleep(50);
            }
        }
    }
}