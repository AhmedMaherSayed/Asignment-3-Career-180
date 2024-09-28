using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_3
{
    public static class ApplicationData
    {
        public static List<Customer> Customers { get; set; } = new List<Customer>();
        public static List<Movie> Movies { get; set; } = new List<Movie>();
        public static List<Employee> Employees { get; set; } = new List<Employee>();

        /// <summary>
        /// AddCustomer new customer.
        /// </summary>
        /// <param name="customer"></param>
        public static void AddCustomer(Customer customer)
            => Customers.Add(customer);
        public static void AddMovie(Movie movie)
            => Movies.Add(movie);
        
        public static void AddEmployee(Employee employee)
            => Employees.Add(employee);

        public static void RemoveEmployee(Employee employee)
             => Employees.Remove(employee);
        public static void RemoveMovie(Movie movie)
             => Movies.Remove(movie);
        public static void RemoveCustomer(Customer customer)
             => Customers.Remove(customer);
    }
}
