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

    public Cell GetCell(int x, int y)
    {
        return cells[x, y];
    }

    public void SetCell(int x, int y, Cell cell)
    {
        cells[x, y] = cell;
    }
}