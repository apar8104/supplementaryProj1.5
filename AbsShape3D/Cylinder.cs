namespace AbsShape3D
{
    public class Cylinder : AbsShape3D
    {
        private double radius;
        private double height;

        /// <summary>
        /// Initializes a new instance of the cylinder class. 
        /// </summary>
        /// <param name="radius">The radius of the cylinder. </param>
        /// <param name="height">The height of the cylinder. </param>
        public Cylinder(double radius, double height)
        {
            Validate(radius, height);
            this.radius = radius;
            this.height = height;
        }

        /// <summary>
        /// Validates the radius and height are greater than zero. 
        /// </summary>
        /// <param name="radius">The radius to validate. </param>
        /// <param name="height">The height to validate. </param>
        /// <exception cref="ArgumentException">Thrown if the 
        // radius/height are less than or equal to zero. </exception>
        private void Validate(double radius, double height)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero. ");
            }
            if (height <= 0)
            {
                throw new ArgumentException("Height must be greater than zero. ");
            }
        }

        public override double GetVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public override double GetSurfaceArea()
        {
            return 2 * Math.PI * radius * (radius + height);
        }

        public override string Dump()
        {
            throw new NotImplementedException();
        }
    }
}