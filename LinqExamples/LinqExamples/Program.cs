using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assume that this comes from a database
            var allEmployees = EmployeeRepository.GetAllEmployees();

            // 0. Print all employees
            // PrintEmployees(allEmployees);

            // 1. Get all employees that have Hourly rate < 30$
            var queryOne = allEmployees.Where(employee => employee.HourlyRate < 30M);
            // PrintEmployees(queryOne);

            // 2. Get all managers that work part time
            var queryTwo = allEmployees
                .Where(
                    employee =>
                        employee.Job.JobType == JobType.Manager &&
                        employee.EmploymentType == EmploymentType.PartTime);

            // PrintEmployees(queryTwo);

            // 3. Calculate average hourly rate of all testers
            var queryThree = allEmployees
                .Where(employee => employee.Job.JobType == JobType.Tester)
                .Average(tester => tester.HourlyRate);

            // Console.WriteLine($"Average per tester hr: {queryThree}");

            // 4. Calculate the monthly salary for all employees (160Hours per month full time, 80 part time) 
            // Result as tuple { FirstName LastName | Salary }
            var queryFour = allEmployees
                .Select(employee =>
                new
                {
                    Name = $"{employee.FirstName} {employee.LastName}",
                    Salary = employee.HourlyRate * (employee.EmploymentType == EmploymentType.FullTime ? 160 : 80),
                });

            //foreach (var annonymouseObject in queryFour)
            //{
            //    Console.WriteLine($"Name: {annonymouseObject.Name} | Salary: {annonymouseObject.Salary}");
            //}

            // 5. Show Top 5 Best earners
            var queryFive = allEmployees
                .OrderByDescending(mihaita => mihaita.HourlyRate)
                .Take(5);

            // PrintEmployees(queryFive);

            // 6. Show the 6 - 10 Best earners
            var querySix = allEmployees
                .OrderByDescending(employee => employee.HourlyRate)
                .Skip(5)
                .Take(5);

            // PrintEmployees(querySix);

            // 7. Show all hourly rates of experts in ascending order
            var querySeven = allEmployees
                .Where(employee => employee.Job.Rank == Rank.Expert)
                .Select(employee => employee.HourlyRate)
                .OrderBy(x => x);

            foreach (var expertRate in querySeven)
            {
                Console.WriteLine(expertRate);
            }

            Console.ReadKey(true);
        }

        static void PrintEmployees(IEnumerable<Employee> employees)
        {
            Console.WriteLine("===================================");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("===================================");
        }
    }
}
