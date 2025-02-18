using System.ComponentModel;

namespace AbsShape3D
{
    public class ShapeContainer
    {
        private List<AbsShape3D> shapes = new List<AbsShape3D>();

        public void Create(AbsShape3D shape)
        {
            throw new NotImplementedException();
        }

        public AbsShape3D Get(int index)
        {
            throw new NotImplementedException();
        }
        
        public bool Delete(int index)
        {
            throw new NotImplementedException();
        }
     }
}