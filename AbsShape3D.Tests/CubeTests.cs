namespace AbsShape3D.Tests
{
    public class CubeTests
    {
        [Fact]
        public void Constructor_ShouldThrowException_WhenSideIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Cube(0));
        }

        [Fact]
        public void Constructor_ShouldThrowException_WhenSideIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Cube(-5));
        }
    } 
}