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

        [Fact]
        public void GetVolume_ShouldReturnCorrectValue()
        {
            double side = 3;
            Cube cube = new Cube(side);

            double volume = cube.GetVolume();

            Assert.Equal(27, volume);
        }

        [Fact]
        public void GetSurfaceArea_ShouldReturnCorrectValue()
        {
            double side = 4;
            Cube cube = new Cube(side);

            double surfaceArea = cube.GetSurfaceArea();

            Assert.Equal(27, surfaceArea);
        }
    } 
}