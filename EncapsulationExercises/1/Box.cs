using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box
{
    // length, width and height.
    private double lenght;

    private double width;
    private double height;

    public Box(double lenght, double width, double height)
    {
        this.Lenght = lenght;
        this.Width = width;
        this.Height = height;
    }

    public double Lenght
    {
        get { return lenght; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Lenght cannot be zero or negative.");
            }
            
                this.lenght = value; 
        }
    }

    public double Width
    {
        get { return width; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    public double Height
    {
        get { return height; }
        private  set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public string SurfaceArea(double lenght, double width, double height)
    {
        // Surface Area = 2lw + 2lh + 2wh
        double surfArea = (2 * this.lenght *this.width) + (2 * lenght * height) + (2 * width * height);
        return $"Surface Area - {surfArea:f2}";

    }

    public string LateralSFArea(double lenght, double width, double height)
    {
        //Lateral Surface Area = 2lh + 2wh
        double lateralSurfaceArea = (2 * lenght * height) + (2 * width * height);
        return $"Lateral Surface Area - {lateralSurfaceArea:f2}";
    }
    public string Volume(double lenght, double width, double height)
    {
        //Volume = lwh
        double volume = (lenght * width * height);
        return $"Volume - {volume:f2}";
    }
   
}

