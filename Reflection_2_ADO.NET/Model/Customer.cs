using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_2_ADO.NET.Model
{
    public class Customer
    {
        public Customer() { }
        public Customer(string fisrtName, string lastName, string phone, string email, SqlDateTime birthdate, string city, int zipCode)
        {
            FisrtName = fisrtName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Birthdate = birthdate;
            City = city;
            ZipCode = zipCode;
        }

        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public SqlDateTime Birthdate { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }

        public override string ToString()
        {
            return $"{FisrtName}\n{LastName}\n{Phone}\n{Email}\n{Birthdate}\n{City}\n{ZipCode}\n";
        }
    }
}
