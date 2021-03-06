using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alekhya_Kariveda_8758013_Assignment2
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public int SetLength(int l)
        {
            this.length = l;
            return this.length;
        }
        public int GetLength()
        {
            return this.length;
        }
        public int SetWidth(int w)
        {
            this.width = w;
            return this.width;
        }
        public int GetWidth()
        {
            return this.width;
        }
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }
        public int GetArea()
        {
            return length * width;
        }
    }
}
