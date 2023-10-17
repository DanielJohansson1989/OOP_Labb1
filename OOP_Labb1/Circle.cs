using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb1
{
    public class Circle
    {
        private float _pi = 3.141f;
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public float GetArea()
        {
            return _radius * _radius * _pi;
        }

        public float GetCircumference()
        {
            return 2 * _pi * _radius;
        }
    }
}
