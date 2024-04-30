using System;

using R5T.T0143;


namespace R5T.T0250
{
    /// <summary>
    /// Attribute indicating an interface is a DB context definition (an interface defining get-only Entity Framework Core DbSet properties).
    /// The marker attribute is useful for surveying DB context definition interfaces and building a catalogue of DB context definitions.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DbContextDefinitionMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsDbContextDefinition;

        /// <summary>
        /// Allows specifying that an interface is *not* a DB context definition interface.
        /// This is useful for marking interfaces that end up canonical DB context definition code file locations, but are not DB context definition interfaces.
        /// </summary>
        public bool IsDbContextDefinition
        {
            get
            {
                return this.zIsDbContextDefinition;
            }
        }


        public DbContextDefinitionMarkerAttribute(
            bool isDbContextDefinition = true)
        {
            this.zIsDbContextDefinition = isDbContextDefinition;
        }
    }
}
