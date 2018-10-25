using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWord.Model
{
    /// <summary>
    /// Object Purpose: To relay information back to the client that does not belong as part of a standard model.
    /// </summary>
    public class ServiceMessage
    {
        /// <summary>
        /// The type of serivce message being returned.
        /// </summary>
        public Severity Severity { get; set; }

        /// <summary>
        /// The content of the service message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Additional information regarding this message.
        /// </summary>
        public List<ServiceMessage> Details { get; set; } = new List<ServiceMessage>();
    }
}
