namespace AbsShape3D.Tests
{
    public class CylinderTests
    {
        [Fact]
        public void Constructor_ShouldThrowException_WhenRadiusIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(0, 5));
        }

        [Fact]
        public void Constructor_ShouldThrowException_WhenHeightIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(3, 0));
        }

        [Fact]
        public void Constructor_ShouldThrowException_WhenRadiusIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(-2, 5));
        }

        [Fact]
        public void Constructor_ShouldThrowException_WhenHeightIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(3, -5));
        }

        [Fact]
        public void GetVolume_ShouldReturnCorrectVolume()
        {
            double radius = 3;
            double height = 5;
            Cylinder cylinder = new Cylinder(radius, height);

            double volume = cylinder.GetVolume();

            Assert.Equal(Math.PI * Math.Pow(radius, 2) * height, volume, 5);
        }

        [Fact]
        public void GetSurfaceArea_ShouldReturnCorrectSurfaceArea()
        {
            double radius = 4;
            double height = 7;
            Cylinder cylinder = new Cylinder(radius, height);

            double surfaceArea = cylinder.GetSurfaceArea();

            Assert.Equal(2 * Math.PI * radius * (radius + height), surfaceArea, 5);
        }

        [Fact]
        public void Dump_ShouldReturnCorrectStringFormat()
        {
            double radius = 2;
            double height = 6;
            Cylinder cylinder = new Cylinder(radius, height);

            string result = cylinder.Dump();

            Assert.Contains("Cylinder", result);
            Assert.Contains("Surface Area: {2 * Math.PI * radius * (radius + height)}", result);
            Assert.Contains("Volume: {Math.PI * Math.Pow(radius, 2) * height}", result);
        }
    }
}