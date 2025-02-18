using System.ComponentModel;

namespace AbsShape3D
{
    public class ShapeContainer
    {
        private List<AbsShape3D> shapes = new List<AbsShape3D>();

        public void Create(AbsShape3D shape)
        {
            shapes.Add(shape);
        }

        public AbsShape3D Get(int index)
        {
            if (index < 0 || index >= shapes.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid index.");
            }
            return shapes[index];
        }
        
        public bool Delete(int index)
        {
            throw new NotImplementedException();
        }
     }
}