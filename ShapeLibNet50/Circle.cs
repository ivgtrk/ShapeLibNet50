using System;
using static System.Math;

namespace ShapeLibNet50
{
    public class Circle : Shape
    {
        /// <summary>
        /// Get Circle Area
        /// </summary>
        /// <param name="r">Radius</param>
        public Circle( double r ) : base( PI * r * r )
        {
            if ( r <= 0.0 )
                throw new ArgumentException( "Provided radius is not a positive double" );
        }
    }
}
