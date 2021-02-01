using System;
using System.Collections.Generic;
using System.Text;

namespace User_defined_class
{
    class Square
    {
        public int length;
        public int area()
        {
            return length * length;
        }
        public int perimeter()
        {
            return 4 * length;
        }
    }
}
