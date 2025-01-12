using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace soft_eng
{
    public class Person
    {
        public Person()
        {
            Id = new Random().Next(1, 10000); // randomly generate new id
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string District { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string OfficeHours { get; set; }

        public override string ToString()
        {
            var details = string.Format($"Telephone: {PhoneNumber}\nEmail: {Email}\nOffice Hours: {OfficeHours}");
            return details;
        }

    }
}