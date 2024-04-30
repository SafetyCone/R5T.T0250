using System;


namespace R5T.T0250
{
    /// <summary>
    /// Marker interface for classes that are DB context implementations (a class inheriting from the Entity Framework Core DbContext class with DbSet get-set properties).
    /// Allows methods-for, and extension methods-on, all types that are DB context implementations.
    /// </summary>
    public interface IDbContextImplementationMarker
    {
    }
}
