using System;

using R5T.T0143;


namespace R5T.T0250
{
    /// <summary>
    /// Attribute indicating a class is a physical DB context implementation (an Entity Framework Core DbContext class that actually managages a physical database via migrations).
    /// The marker attribute is useful for surveying physical DB context implementation classes and building a catalogue of physical DB context implementations.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class PhysicalDbContextImplementationMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsPhysicalDbContextImplementation;

        /// <summary>
        /// Allows specifying that a class is *not* a physical DB context implementation class.
        /// This is useful for marking classes that end up canonical physical DB context implementation code file locations, but are not physical DB context implementation classes.
        /// </summary>
        public bool IsPhysicalDbContextImplementation
        {
            get
            {
                return this.zIsPhysicalDbContextImplementation;
            }
        }


        public PhysicalDbContextImplementationMarkerAttribute(
            bool isPhysicalDbContextImplementation = true)
        {
            this.zIsPhysicalDbContextImplementation = isPhysicalDbContextImplementation;
        }
    }
}
