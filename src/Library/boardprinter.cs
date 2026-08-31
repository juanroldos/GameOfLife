using System;


public class BoardPrinter
{
   public void PrintBoard(Board board)
{
    int width = board.Width;
    int height = board.Height;

    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            Console.Write(board.GetCell(x, y).IsAlive ? "X" : " ");
        }
        Console.WriteLine();
    }
} 
}

