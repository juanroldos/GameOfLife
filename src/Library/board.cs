public class Board
{
    private int width;
    private int height;
    private Cell[,] cells;

    public int Width
    {
        get { return width; }
    }

    public int Height
    {
        get { return height; }
    }

    public Board(int width, int height)
    {
        this.width = width;
        this.height = height;
        this.cells = new Cell[width, height];
    }

    public bool IsAlive(int x, int y)
    {
        return cells[x, y].IsAlive;
    }

    public void SetCell(int x, int y, bool isAlive)
    {
        cells[x, y] = new Cell(isAlive);
    }
}