namespace ParaClub
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;
            Console.CursorVisible = Config.CursonVisible;

            ConsoleKeyInfo keyPressed;
            int Verif = 0;

            Plane plane = new Plane();
            plane.draw();

            Para bob = new Para("Bob");
            Para Sarah = new Para("Sarah");

            //Console.ReadLine();

            while (true)
            {

                plane.update();

                // Temporiser
                Console.Clear();
                plane.draw();

                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            Verif = 1;
                            break;
                    }
                }
                if(Verif == 1)
                {
                    plane.dropParachutist();
                }

                //Temporiser
                Thread.Sleep(50);

            }
        }
    }
}
