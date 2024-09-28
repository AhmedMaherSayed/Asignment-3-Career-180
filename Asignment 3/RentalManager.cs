using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_3
{
    public class RentalManager : Employee, IManageCustomer, IManageEmployees, IManageMovie
    {
        public void AddCustomer(Customer customer)
        {
            //var customer = new Customer();
            //Console.WriteLine("Enter Customer Id");
            //customer.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Customer Name");
            //customer.Name = Console.ReadLine();
            //Console.WriteLine("Enter Customer Phone");
            //customer.Phone = Console.ReadLine();
            //Console.WriteLine("Enter Customer Email");
            //customer.Email = Console.ReadLine();
            //Console.WriteLine("Enter Customer Address");
            //customer.Address = Console.ReadLine();
            //Console.WriteLine("Enter Customer PersonalPhoto");
            //customer.PersonalPhoto = Console.ReadLine();

            if(customer is not null)
            ApplicationData.AddCustomer(customer);
        }

        public void AddEmployee(Employee employee)
        {
            //var employee = new Employee();
            //Console.WriteLine("Enter Customer Id");
            //employee.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Customer Name");
            //employee.Name = Console.ReadLine();
            //Console.WriteLine("Enter Customer Phone");
            //employee.Phone = Console.ReadLine();
            //Console.WriteLine("Enter Customer Email");
            //employee.Email = Console.ReadLine();
            //Console.WriteLine("Enter Customer Address");
            //employee.Address = Console.ReadLine();
            //Console.WriteLine("Enter Customer PersonalPhoto");
            //employee.PersonalPhoto = Console.ReadLine();
           
            if(employee is not null)
            ApplicationData.AddEmployee(employee);
        }

        public void AddMovie(Movie movie)
        { 
            
            ApplicationData.AddMovie(movie);
        }

        public bool AvailableForRent(Movie movie)
        {
            if (ApplicationData.Movies.Contains(movie))
                return true;
            return false;
        }

        public void RemoveCustomer(Customer customer)
        {
            if (ApplicationData.Customers.Contains(customer))
            {
                ApplicationData.Customers.Remove(customer);
                Console.WriteLine($"Movie with id = {customer.Id} is deleted!");
            }
            else
                Console.WriteLine($"Movie with id = {customer.Id} is not deleted!");
        }

        public void RemoveEmployee(Employee employee)
        {
            if (ApplicationData.Employees.Contains(employee))
            {
                ApplicationData.Employees.Remove(employee);
                Console.WriteLine($"Movie with id = {employee.Id} is deleted!");
            }
            else
                Console.WriteLine($"Movie with id = {employee.Id} is not deleted!");
        }

        public void RemoveMovie(Movie movie)
        {
            if(ApplicationData.Movies.Contains(movie))
            {
                ApplicationData.Movies.Remove(movie);
                Console.WriteLine($"Movie with id = {movie.Id} is deleted!");
            }
            else
                Console.WriteLine($"Movie with id = {movie.Id} is not deleted!");

        }
    }
}
