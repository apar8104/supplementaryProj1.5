namespace AbsShape3D.Tests
{
    public class SphereTests
    {
        [Fact]
        public void Constructor_ShouldThrowException_WhenRadiusIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Sphere(0));
        }

        [Fact]
        public void Constructor_ShouldThrowException_WhenRadiusIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Sphere(-5));
        }

        [Fact]
        public void GetVolume_ShouldReturnCorrectVolume()
        {
            double radius = 3;
            Sphere sphere = new Sphere(radius);

            double volume = sphere.GetVolume();

            Assert.Equal((4.0/3.0) * Math.PI * Math.Pow(radius, 3), volume, 5);
        }

        [Fact]
        public void GetSurfaceArea_ShouldReturnCorrectSurfaceArea()
        {
            double radius = 4;
            Sphere sphere = new Sphere(radius);

            double surfaceArea = sphere.GetSurfaceArea();

            Assert.Equal(4 * Math.PI * Math.Pow(radius, 2), surfaceArea, 5);
        }
    }
}