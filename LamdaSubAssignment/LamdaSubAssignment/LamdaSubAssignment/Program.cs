using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the employeeList");
            List<Employee> EmpList1 = new List<Employee>()
            {
                new Employee
                {
                    FirstName = "Bob", LastName = "Bobby", ID = 1
                },
                new Employee
                {
                    FirstName = "Joe", LastName = "Don", ID = 2
                },
                new Employee
                {
                    FirstName = "Joe", LastName = "Will", ID = 3
                },
                new Employee
                {
                    FirstName = "Billy", LastName = "Joel", ID = 4
                },
                new Employee
                {
                    FirstName = "Ben", LastName = "Foster", ID = 5
                },
                new Employee
                {
                    FirstName = "Jed", LastName = "Johnson", ID = 6
                },
                new Employee
                {
                    FirstName = "Jon", LastName = "Smith", ID = 7
                },
                new Employee
                {
                    FirstName = "Beth", LastName = "Judi", ID = 8
                },
                new Employee
                {
                    FirstName = "Jonny", LastName = "Smithy", ID = 9
                },
                new Employee
                {
                    FirstName = "Bethy", LastName = "Judiy", ID = 10
                }
            };
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee emp in EmpList1)
            {
                if (emp.FirstName == "Joe")
                {
                    JoeList.Add(emp);
                }
            }
            foreach (Employee employee in JoeList)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.ID);
            }

            List<Employee> employeeTrack2 = EmpList1.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> employeeTrack3 = EmpList1.Where(x => x.ID > 5).ToList();
            foreach (Employee employee in employeeTrack3)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.ID);
            }
            foreach (Employee employee in employeeTrack2)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.ID);
            }
            Console.ReadLine();
        }
    }
}
