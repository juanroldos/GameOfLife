static void PrintBoard(bool[,] board)
{
    int width = board.GetLength(0);
    int height = board.GetLength(1);

    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            Console.Write(board[x, y] ? "X" : " ");
        }
        Console.WriteLine();
    }
}