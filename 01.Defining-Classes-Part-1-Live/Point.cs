public class Point
{
    private string name;
    private int xCord;
    private int yCord;


    public Point(): this(0,0)
    {
    }

    public Point(int xCord,int yCord)
    {
        this.xCord = xCord;
        this.yCord = yCord;
        this.name = string.Format("Point({0},{1})", xCord, yCord);
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int XCord
    {
        get { return this.xCord; }
        set { this.xCord = value; }
    }

    public int Ycord
    {
        get { return this.yCord; }
        set { this.yCord = value; }
    }
}