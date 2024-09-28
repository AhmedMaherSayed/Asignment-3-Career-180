namespace Asignment_3
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public bool Availability { get; set; }
        public double Rate { get; set; }
        public Genre MovieType { get; set; }
    }
}