using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Height
        {
            get { return height; }
             set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                    height = value;
            }
        }

        public double Width
        {
            get { return width; }
             set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                    width = value;
            }
        }

        public double Length
        {
            get { return length; }
             set
            {
                if (value <=0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                    length = value;
               

            }
        }
        public Box(double length,double width, double height)
        {
            Length= length;
            Width= width;
            Height= height;
        }
        public double SurfaceArea()
        {
            return 2 * Length * Width + 2 * Height * Length + 2 * Width * Height;
        }
        public double LateralSurfaceArea()
        {
            return 2*height*(length+width);
        }
        public double Volume()
        {
            return  height * length * width;
        }
    }
}
