namespace CodePhilippe01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SNAIL_POS_Y = 15;
            const int SNAIL_SPEED = 39;

            int snailLife = 50;
            int x = 0;

            Console.CursorVisible = false;

            /*
            while(snailLife != 0)
            {
                Console.SetCursorPosition(x, SNAIL_POS_Y);
                Thread.Sleep(SNAIL_SPEED);

                Snail(0);

                x++;
                snailLife--;
            }
            */

            Snail(0);
            Console.MoveBufferArea(x, 0, 8, 2, x++, SNAIL_POS_Y);

            while (snailLife != 0)
            {
                Console.MoveBufferArea(x,SNAIL_POS_Y, 8, 2, x++, SNAIL_POS_Y);

                Thread.Sleep(SNAIL_SPEED);

                //Snail(0);

                snailLife--;
            }

            Console.SetCursorPosition(x, SNAIL_POS_Y);
            Snail(1);

            Console.ReadLine();

            void Snail(int Pos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                if (Pos == 0)
                    Console.Write(" _@_ö");
                else if (Pos == 1)
                    Console.Write(" ____");

                Console.ResetColor();
            }
        }
    }
}