using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3_2
{
    class ShapeFactory
    {
        public Shape GetShape(String shapeType)
        {
            if(shapeType == null)
            {
                return null;
            }

            if(shapeType == "CIRCLE")
            {
                return new Circle();
            }
            else if (shapeType == "RECTANGLE")
            {
                return new Rectangle();
            }
            else if (shapeType == "TRIANGLE")
            {
                return new Triangle();
            }
            else if (shapeType == "SQUARE")
            {
                return new Square();
            }
            return null;
        }
    }
}
