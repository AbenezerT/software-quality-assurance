using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbeAssignment1
{
    public class AbeCircle
    {
        private int radius;
    
        //Default Constructor which sets the value of the radius to 1

        public AbeCircle()
        {
            this.radius = 1;
        }
        //Non-default Constructor which sets the value of the radius to the value passed
        public AbeCircle(int radius)
        {
            this.radius = radius;
        }
        //Returns the value of the Circle radius
        public int GetRadius()
        {
            return radius;

        }
        //Sets the value of the Circle radius
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        //Calculates and returns the circumference of the Circle
        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }
        // Calculates and returns the area of the Circle
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

    }
}
