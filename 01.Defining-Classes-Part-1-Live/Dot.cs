using System;

public class Dot
{
    private int xCord;
    private int yCord;

    public Dot(int xCord, int yCord)
    {
        this.xCord = xCord;
        this.yCord = yCord;
    }

    public double CalculateDistance(Dot p)
    {
        return Math.Sqrt(
            (p.xCord - this.xCord) * (p.xCord - this.xCord) +
            (p.yCord - this.yCord) * (p.yCord - this.yCord));
    }
    public override string ToString()
    {
        return string.Format("Dot with Xcord: {0} and Ycord: {1}",this.xCord,this.yCord);
    }
}