using System.Net.Http.Headers;

namespace AbsShape3D
{
    public class Sphere : AbsShape3D
    {
        private double radius;

        /// <summary>
        /// Initializes a new instance of the Sphere class. 
        /// </summary>
        /// <param name="radius">Radius of the sphere. </param>
        public Sphere(double radius)
        {
            Validate(radius);
            this.radius = radius;
        }

        /// <summary>
        /// Validates that the radius of the sphere is greater than zero. 
        /// </summary>
        /// <param name="radius">The radius of the sphere. </param>
        /// <exception cref="ArgumentException">Thrown if the radius is 
        /// less than or equal to zero. </exception>
        private void Validate (double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero. ");
            }
        }

        public override double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        public override double GetSurfaceArea()
        {
            throw new NotImplementedException();
        }

        public override string Dump()
        {
            throw new NotImplementedException();
        }
    }
}