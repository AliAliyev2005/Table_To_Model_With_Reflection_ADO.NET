using Reflection_2_ADO.NET.Model;
using System;

namespace Reflection_2_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var customer in DataReader.GetData("Customers"))
            {
                Console.WriteLine(customer);
            }
        }
    }
}
