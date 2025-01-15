using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP04
{
    internal class Rectangle
    {
        #region Q2) Create a class named Rectangle with the following constructors:
        //●	A parameterless constructor that sets the width and height to 0.
        //●	A constructor that accepts width and height as integers.
        //●	A constructor that accepts a single integer and sets both width and height to that value.
        private int width;
        private int height;
        public Rectangle()
        {
            width = 0;
            height = 0;
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(int width) : this(width, 200)
        { this.width=width; }
        public override string ToString()
        {
            return $"width:{width},height:{height}";
        }
        #endregion

    }
}
