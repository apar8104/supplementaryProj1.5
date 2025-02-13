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

        private void Validate(double radius, double height)
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