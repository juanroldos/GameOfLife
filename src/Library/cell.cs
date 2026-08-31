using System;

public class Cell
{
    private bool isAlive;
    public bool IsAlive
    {
        get { return isAlive; }
    }

    public Cell(bool isAlive)
    {
        this.isAlive = isAlive;
    }

    public void ChangeState()
    {
        isAlive = !isAlive;
    }



}