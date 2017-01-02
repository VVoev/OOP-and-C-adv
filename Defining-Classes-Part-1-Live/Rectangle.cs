public class Rectangle
{
    private float width;
    private float height;


    public Rectangle(float witdh, float height)
    {
        this.width = witdh;
        this.height = height;
    }
    public float Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public float Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public float Area
    {
        get { return height * width; }
    }
}