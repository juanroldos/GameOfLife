using System;
using System.IO;

public class BoardImporter
{
    public BoardImporter()
    {
    }
    public bool[,] ImportBoard(string ruta )
    {

    string content = File.ReadAllText(ruta);
    string[] contentLines = content.Split('\n');
    bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
    for (int  y=0; y<contentLines.Length;y++)
    {
        for (int x=0; x<contentLines[y].Length; x++)
        {
            if(contentLines[y][x]=='1')
            {
                board[x,y]=true;
            }
        }
    }
    return board;

    }
    }
