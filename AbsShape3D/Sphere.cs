using System.Net.Http.Headers;

namespace AbsShape3D
{
    public class Sphere : AbsShape3D
    {
        private double radius;

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