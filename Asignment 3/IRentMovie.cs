using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_3
{
    public interface IRentMovie
    {
        void RentMovie(int customerId, int movieId, int? employeeId);
    }
}
