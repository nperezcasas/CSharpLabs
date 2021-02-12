﻿using System;

namespace ShapeAreaCalculator
{
    public class Circle : Shape
    {
        // 1. Create a Circle constructor method and set its
        //    Name and Sides properties. A circle has 0 sides.

        public Circle()
        {
            Name = "Circle";
            Sides = 0;
        }

        // 2. A Circle's Height and Width must always be the same.
        //    So override the Height and Width properties here.
        //    Hint: If you have already completed the Square class
        //    you can copy the code for these properties from there.
        public override double Height
        {
            get { return base.Height; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        // 3. Add a Width property here.
        public override double Width
        {
            get { return base.Width; }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }


        // 4. Add a Radius property to the Circle class. 
        //    "Getting" it returns half the Width property's value.
        //    "Setting" it sets both the Height and Width properties 
        //    to twice the Radius value. 
       
        public double Radius
        {
            get { return 0.5 * Height; }
            set
            {
                Height = 2 * value;
            }
        }


        // A circle's area is πr². 
        // We can use C#'s static Math class's PI property 
        // and Pow method to do this calculation.
        // Since we have not covered using C#'s Math
        // class, this method is provided for you.
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

}
