using System;
using System.Collections.Generic;
using System.Text;

namespace User_defined_class
{
    class Rectangle
    {
        public int l, b;
        public int area()
        {
            return l * b;
        }
        public int perimeter()
        {
            return (2*(l + b));
        }
    }
}
