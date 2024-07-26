namespace Kiss;

public class OtherRectangle
{
    private int width;
    private int height;

    public OtherRectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public int GetWidth()
    {
        return width;
    }

    public int GetHeight()
    {
        return height;
    }

    public int CalculateArea()
    {
        int area = 0;
        area = GetWidth() * GetHeight();
        return area;
    }
}