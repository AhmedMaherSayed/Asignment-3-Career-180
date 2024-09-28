using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_3
{
    public class Employee : Person, IPerson, ICreateCustomer
    {
        public DateTime HaringDate { get; set; }


        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        public  void CreateCustomer(ICustomer newCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
