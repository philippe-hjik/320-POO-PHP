namespace CodePhilippe01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SNAIL_POS_Y = 15;
            const int SNAIL_LIFE = 50;

            for (int i = 0; i != SNAIL_LIFE; i++)
            {
                Console.SetCursorPosition(i, SNAIL_POS_Y);
                Thread.Sleep(39);

                Snail(0);
            }
            Console.SetCursorPosition(50, SNAIL_POS_Y);
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