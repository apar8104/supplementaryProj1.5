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

        private void Validate (double radius)
        {
            throw new NotImplementedException();
        }

        public override double GetVolume()
        {
            throw new NotImplementedException();
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