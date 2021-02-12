﻿using System;

namespace ShapeAreaCalculator
{
    // The Square class inherits the Rectangle class which inherits the Shape class.
    sealed public class Square : Rectangle
    {
        // 1. Create a Square constructor method and set its Name property.
        //    We don't have to set the Sides property because Square extends
        //    Rectangle which already sets its Sides property to 4.
        public Square()
        {
            Name = "Square";
        }


        // A Square's Height and Width must always be the same.
        // So override the Height and Width properties here.
        // The Height property has been done for you. 
        // Use it as a guide to build the Width property below.
        public override double Height
        {
            get { return base.Height; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        // 2. Use the Height property above as a guide to add the Width property here.
        public override double Width
        {
            get { return base.Width; }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

        // Square does not need an Area method because it inherits that from
        // its base Rectangle class.  So you don't need to do that here.
    }
}
