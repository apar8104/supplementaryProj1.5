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

        /// <summary>
        /// Validates that the side length is greater than 0.
        /// </summary>
        /// <param name="side">The side length of the cube. </param>
        /// <exception cref="ArgumentException">Throw is the cube side 
        // is less than or equal to zero. </exception>
        private void Validate(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Side length must be greater than zero. ");
            }
        }

        public override double GetVolume()
        {
            return Math.Pow(side, 3);
        }

        public override double GetSurfaceArea()
        {
            return 6 * Math.Pow(side, 2);
        }

        public override string Dump()
        {
            throw new NotImplementedException();

        }
    }
}