﻿using System;

namespace ShapeAreaCalculator
{
    public class Triangle : Shape
    {
        // 1. Add a public Triangle constructor.
        //    Set the Name and Sides properties in the constructor.
        //    Name = "Triangle" Sides = 3
        public Triangle()
        {
            Name = "Triangle";
            Sides = 3;
        }

        // 2. The Shape abstract base class requires its
        //    derived classes to implement an Area method.
        //    Remember you will need to use the "override" keyword to do this.
        //    The area of a triangle is (height X width) / 2.
        public override double Area()
        {
            return (Height * Width) / 2;
        }


    }
}
