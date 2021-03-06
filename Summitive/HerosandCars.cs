﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Summitive
{
    class HerosandCars
    {
        public Color color;
        public int x, y, size;

        public HerosandCars(int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
        }

        public HerosandCars(int _x, int _y, int _size, Color _color)
        {
            x = _x;
            y = _y;
            size = _size;
            color = _color;
        }

        public void Move(int speed)
        {
            y += speed;
        }

        public void Move(int speed, string direction)
        {
            //true represents right
            if (direction == "right")
            {
                x += speed;
            }
            else
            {
                x -= speed;
            }
        }
    }
}
