using System;

namespace CSGradeBook
{
    /// <summary>
    /// The Event argument inherits from EventArgs object
    /// </summary>
    public class NamedChangedEventArgs : EventArgs
    {
        // auto implemented name properties
        public string ExistingName { get; set; }
        public string NewName { get; set; }
    }
}
