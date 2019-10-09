using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RecurrenceAppointment
{
    /// <summary>
    /// Represents custom data properties.
    /// </summary>
    public class Meeting
    {
        public string EventName { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Brush Color { get; set; }
        public string RecurrenceRule { get; set; }
        public bool IsRecursive { get; set; }
    }
}
