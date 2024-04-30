using System;


namespace R5T.T0250
{
    /// <summary>
    /// Marker interface for classes that are physical DB context implementations (an Entity Framework Core DbContext class that actually managages a physical database via migrations).
    /// Allows methods-for, and extension methods-on, all types that are physical DB context implementations.
    /// </summary>
    public interface IPhysicalDbContextImplementationMarker
    {
    }
}
