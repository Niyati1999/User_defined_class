using System;
using System.Collections.Generic;
using System.Text;

namespace User_defined_class
{
    class Rectangle
    {
        private int l, b;

        public int B { get => b; set => b = value; }

        public void setLength(int value)
        {
            if (value > 0)
            {
                l = value;
            }
            else
            {
                l = 0;
            }
        } 
        public int getLenght()
        {
            return l;
        }
        public int area()
        {
            return l * B;
        }
        public int perimeter()
        {
            return (2*(l + B));
        }
    }
}
