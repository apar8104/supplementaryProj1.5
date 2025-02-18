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

        [Fact]
        public void Create_ShouldReturnCorrectShape()
        {
            var container = new ShapeContainer();
            var sphere = new Sphere(3);

            container.Create(sphere);

            var result = container.Get(0);

            Assert.Equal(sphere, result);
        }
    }
}