namespace AbsShape3D.Tests
{
    public class CylinderTests
    {
        [Fact]
        public void Constructor_ShouldThrowException_WhenRadiusIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(0, 5));
        }
    }
}