using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_3
{
    /// <summary>
    /// OccasionallyEmployee is working as a contractor in the week ends and ruch days.
    /// </summary>
    public class OccasionallyEmployee : Employee, IPerson
    {
        public decimal HourlyRate { get; set; }

    }
}
