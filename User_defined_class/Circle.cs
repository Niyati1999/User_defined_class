using System;
using System.Collections.Generic;
using System.Text;

namespace User_defined_class
{
    class Circle
    {
        public double Radius { get; set; }
        public double area()
        {
            return (Math.PI * Radius * Radius);
        }
    }
}
