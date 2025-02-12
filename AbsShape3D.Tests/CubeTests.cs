namespace AbsShape3D.Tests
{
    public class CubeTests
    {
        [Fact]
        public void Contructor_ShouldThrowException_WhenSideIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Cube(0));
        }
    } 
}