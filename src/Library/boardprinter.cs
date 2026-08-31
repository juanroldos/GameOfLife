using System;
using System.Text;
using System.Threading;


public class BoardPrinter
{
    public BoardPrinter()
    {
        
    }

    public void PrintBoard(Board board)
    {
        bool[,] b; // Variable que representa el tablero
        while (true)
    {
        Console.Clear();
        StringBuilder s = new StringBuilder();
        for (int y = 0; y<board.Height;y++)
        {
            for (int x = 0; x<board.Width; x++)
            {
                if(b[x,y])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n");
        }
        Console.WriteLine(s.ToString());
        //=================================================
        //Invocar método para calcular siguiente generación
        //=================================================
        Thread.Sleep(300);
    }
    }
}