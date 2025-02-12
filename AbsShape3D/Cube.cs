using System.Net.Http.Headers;

namespace AbsShape3D{
    public class Cube : AbsShape3D
    {
        private double side;

        public Cube(double side)
        {
            Validate(side);
            this.side = side;
        }

        private void Validate(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Side length must be greater than zero. ");
            }
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