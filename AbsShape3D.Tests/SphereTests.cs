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
    }
}