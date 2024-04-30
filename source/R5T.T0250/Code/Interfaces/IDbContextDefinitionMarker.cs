using System;


namespace R5T.T0250
{
    /// <summary>
    /// Marker interface for interfaces that are DB context definitions (interfaces defining get-only Entity Framework Core DbSet properties).
    /// Allows methods-for, and extension methods-on, all types that are DB context definitions.
    /// </summary>
    public interface IDbContextDefinitionMarker
    {
    }
}
