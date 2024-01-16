using System;

///<summary> Defines a Shape.</summary>
class Shape
{
    ///<summary>Return the area of the shape.</summary>
    ///<returns>The area of the shape.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }

    ///<summary>Converts the shape to a string representation.</summary>
    ///<returns>A string representation of the shape.</returns>
    public override string ToString()
    {
        return "[Shape]";
    }
}

///<summary> Defines a Rectangle, inherits from Shape.</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    ///<summary>Gets or sets the rectangle's width.</summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    ///<summary>Gets or sets the rectangle's height.</summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }

    ///<summary>Calculates and returns the area of the rectangle.</summary>
    ///<returns>The area of the rectangle.</returns>
    public override int Area()
    {
        return width * height;
    }

    ///<summary>Converts the rectangle to a string representation.</summary>
    ///<returns>A string representation of the rectangle.</returns>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

///<summary> Defines a Square, inherits from Rectangle.</summary>
class Square : Rectangle
{
    private int size;

    ///<summary>Gets or sets the square's size.</summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                size = value;
                Width = size;
                Height = size;
            }
        }
    }
}
