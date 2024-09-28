namespace Asignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cairoBranch = new Branch();
            cairoBranch.Id = 1;
            cairoBranch.Name = "Cairo Branch";
            


            var rentManagerOne = new RentalManager();
            rentManagerOne.Id = 1;
            rentManagerOne.Name = "Manager 1";
            rentManagerOne.Address = "Cairo";
            rentManagerOne.BranchId = 1;
            rentManagerOne.HaringDate = DateTime.Now;
            rentManagerOne.Branch = cairoBranch;
            rentManagerOne.Branch.NoOfEmployees++;

            Console.WriteLine($"Branch name = {cairoBranch.Name} :: nuber of employee = {cairoBranch.NoOfEmployees}");
            
            var movie = new Movie();
            movie.Id = 1;
            movie.Title = "Movie1";
            movie.Availability = true;
            movie.MovieType = Genre.Comedy;
            movie.Rate = 9.8;
            rentManagerOne.AddMovie(movie);


            var customerOne = new Customer();
            customerOne.Id = 1;
            customerOne.Name = " Ahmed";
            customerOne.Address = "Cairo";
            customerOne.Email = "Ahmed@gmail.com";
            customerOne.Phone = "12213";
            customerOne.PersonalPhoto = "2.jpg";
            rentManagerOne.AddCustomer(customerOne);
        }
    }
}
