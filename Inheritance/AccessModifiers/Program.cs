using System;

namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {

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
