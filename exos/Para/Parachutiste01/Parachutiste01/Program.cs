namespace Parachutiste01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;
            Console.CursorVisible = Config.CursonVisible;

            ConsoleKeyInfo keyPressed;
            
            Plane plane = new Plane();

            List<Para> paraClub = new List<Para>();
            paraClub.Add(new Para("Bob"));
            paraClub.Add(new Para("Alice"));

            foreach (Para para in paraClub)
            {
                para.isInAPlane = true;
                plane.board(para);
            }

            while (true)
            {
                Console.Clear();
                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);

                    switch(keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            plane.dropParachutist();
                            break;
                    }
                }
                

                plane.update();
                foreach (Para para in paraClub)
                {
                    para.updatePara();
                }

                plane.draw();
                foreach (Para para in paraClub)
                {
                    para.drawPara();
                }



                Thread.Sleep(20);
            }
            
        }
    }
}