namespace AbsShape3D.Tests
{
    public class ShapeContainerTests
    {
        [Fact]
        public void Create_ShouldAddShapeToContainer()
        {
            var container = new ShapeContainer();
            var cube = new Cube(2);

            container.Create(cube);

            Assert.Equal(cube, container.Get(0));
        }
    }
}