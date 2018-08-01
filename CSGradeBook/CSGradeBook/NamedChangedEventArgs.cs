using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
