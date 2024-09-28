using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_3
{
    public interface IManageMovie
    {
        public void AddMovie(Movie movie);
        public void RemoveMovie(Movie movie);
        public bool AvailableForRent(Movie movie);
    }
}
