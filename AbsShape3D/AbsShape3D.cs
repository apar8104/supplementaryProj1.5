namespace AbsShape3D;

public abstract class AbsShape3D
{
    /// <summary>
    /// Calculates the volume of a shape. 
    /// </summary>
    /// <returns>The volume of the shape as a double. </returns>
    public abstract double GetVolume();

    /// <summary>
    /// Calculates the surface area of the shape.
    /// </summary>
    /// <returns>The surface area as a double. </returns>
    public abstract double GetSurfaceArea();

    public abstract string Dump();
}
