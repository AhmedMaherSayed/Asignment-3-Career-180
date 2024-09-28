using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_3
{
    public class Customer : Person, ICustomer, IRentMovie, IReturnMovie
    {
        public virtual void RentMovie(int customerId, int movieId, int? employeeId)
        {
            if(employeeId is not null)
            {
                Console.WriteLine($"Movie with id {movieId} is rented by the customer with id {customerId} by the employee {employeeId}");

            }

            Console.WriteLine($"Movie with id {movieId} is rented by the customer with id {customerId}");
        }
        public virtual void ReturnMovie(int customerId, int movieId, int? employeeId)
        {
            if(employeeId is not null)
            {
                Console.WriteLine($"Movie with id {movieId} is Returned by the customer with id {customerId} by the employee {employeeId}");

            }

            Console.WriteLine($"Movie with id {movieId} is Returned by the customer with id {customerId}");
        }

        
    }
}
