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

        [Fact]
        public void Get_ShouldThrowException_WhenIndexIsInvalid()
        {
            var container = new ShapeContainer();

            Assert.Throws<ArgumentOutOfRangeException>(() => container.Get(0));
        }

        [Fact]
        public void Delete_ShouldRemoveShapeFromContainer()
        {
            var container = new ShapeContainer();
            var cylinder = new Cylinder(2, 5);
            container.Create(cylinder);

            bool result = container.Delete(0);

            Assert.True(result);
            Assert.Throws<ArgumentOutOfRangeException>(() => container.Get(0));
        }
    }
}