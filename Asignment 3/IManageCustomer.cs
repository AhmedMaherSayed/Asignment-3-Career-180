using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_3
{
    public interface IManageCustomer
    {
        public void AddCustomer(Customer customer);
        public void RemoveCustomer(Customer customer);
    }
}
