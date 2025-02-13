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
    }
}