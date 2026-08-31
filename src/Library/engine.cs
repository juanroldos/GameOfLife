using System;

public class Engine
{
    public Board NextGeneration(Board board)
    {
        Board nextBoard = new Board(board.Width, board.Height);
        for (int x = 0; x < board.Width; x++)
        {
            for (int y = 0; y < board.Height; y++)
            {
            int aliveNeighbors = this.CountAliveNeighbours(board, x, y);
            bool isAlive = board.GetCell(x, y).IsAlive;
            bool willBeAlive = (isAlive && (aliveNeighbors == 2 || aliveNeighbors == 3)) || (!isAlive && aliveNeighbors == 3);
            nextBoard.SetCell(x, y, new Cell(willBeAlive));
            }
        }
        return nextBoard;

    }

    private int CountAliveNeighbours(Board board, int x, int y)
    {
        int aliveNeighbours = 0;

        for (int i = x - 1; i <= x + 1; i++)
        {
            for (int j = y - 1; j <= y + 1; j++)
            {
                if (i >= 0 && i < board.Width && j >= 0 && j < board.Height && board.GetCell(i, j).IsAlive)
                {
                    aliveNeighbours++;
                }
            }
        }

        if (board.GetCell(x, y).IsAlive)
        {
            aliveNeighbours--;
        }

        return aliveNeighbours;
    }
}
