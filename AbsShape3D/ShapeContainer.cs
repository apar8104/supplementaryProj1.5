using System.ComponentModel;

namespace AbsShape3D
{
    public class ShapeContainer
    {
        private List<AbsShape3D> shapes = new List<AbsShape3D>();

        /// <summary>
        /// Adds a AbsShape3D object to the container. 
        /// </summary>
        /// <param name="shape">The shape to add to the container.</param>
        public void Create(AbsShape3D shape)
        {
            shapes.Add(shape);
        }

        /// <summary>
        /// Retrieves the AbsShape3D object at the specified index.
        /// </summary>
        /// <param name="index">The index of the shape to retrieve. </param>
        /// <returns>The Absshape3D object at the specified index. </returns>
        /// <exception cref="ArgumentOutOfRangeException"> Thrown if the index is invalid.</exception>
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
            if (index < 0 || index >= shapes.Count)
            {
                return false;
            }
            shapes.RemoveAt(index);
            return true;
        }
     }
}