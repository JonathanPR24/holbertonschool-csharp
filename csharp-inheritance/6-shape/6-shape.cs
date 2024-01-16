using System;

///<summary> Defines a Shape.</summary>
class Shape
{
    ///<summary>Return the area of the shape.</summary>
    ///<returns>The aera of the shape.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary> Defines a Rectangle, inherits from Shape.</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    ///<summary>Gets or sets the shape's width</summary>
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

    ///<summary>Gets or sets the shape's height</summary>
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
}