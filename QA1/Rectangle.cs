using System;
using System.Collections.Generic;
using System.Text;

namespace QA1
{
    public class Rectangle
    {
        // rectangle width + length
        private int rectLeng, rectWid;

        // setup
        public Rectangle()
        {
            // set base values
            rectLeng = 1;
            rectWid = 1;
        }

        // get length
        public int GetLength()
        {
            return rectLeng;
        }

        // set length
        public int SetLength(int length)
        {
            rectLeng = length;
            return rectLeng;
        }

        // get width
        public int GetWidth()
        {
            return rectWid;
        }

        // set  width
        public int SetWidth(int width)
        {
            rectWid = width;
            return rectWid;
        }

        // calc perimeter
        public int GetPerimeter()
        {
            return rectLeng * 2 + rectWid * 2;
        }

        // calc area
        public int GetArea()
        {
            return rectLeng * rectWid;
        }
    }
}
