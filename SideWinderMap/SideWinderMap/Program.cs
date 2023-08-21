using System;

class Program
{
    static void Main(string[] args)
    {


        Board board = new Board();
        board.Init(25);

        Console.CursorVisible = false;

        const int WAIT_TICK = 10000 / 30;
        int lastTick = 0;

        while (true)
        {
            #region 프레임관리
            int currentTick = System.Environment.TickCount;
            if (currentTick - lastTick < WAIT_TICK)
                continue;
            lastTick = currentTick;
            #endregion

            Console.SetCursorPosition(0, 0);
            board.Render();
        }

    }
}

