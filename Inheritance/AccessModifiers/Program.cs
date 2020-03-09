using System;

namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
                Console.WriteLine("Promote to Level 1");
            else
                Console.WriteLine("Promooted to Level 2");
        }

        public int CalculateRating()
        {
            return 0;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

        }
    }
}
