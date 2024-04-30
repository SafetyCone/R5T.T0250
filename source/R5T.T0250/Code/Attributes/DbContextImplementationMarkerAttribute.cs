using System;

using R5T.T0143;


namespace R5T.T0250
{
    /// <summary>
    /// Attribute indicating a class is a DB context implementation (a class inheriting from the Entity Framework Core DbContext class with DbSet get-set properties).
    /// The marker attribute is useful for surveying DB context implementation classes and building a catalogue of DB context implementations.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DbContextImplementationMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsDbContextImplementation;

        /// <summary>
        /// Allows specifying that a class is *not* a DB context implementation class.
        /// This is useful for marking classes that end up canonical DB context implementation code file locations, but are not DB context implementation classes.
        /// </summary>
        public bool IsDbContextImplementation
        {
            get
            {
                return this.zIsDbContextImplementation;
            }
        }


        public DbContextImplementationMarkerAttribute(
            bool isDbContextImplementation = true)
        {
            this.zIsDbContextImplementation = isDbContextImplementation;
        }
    }
}
