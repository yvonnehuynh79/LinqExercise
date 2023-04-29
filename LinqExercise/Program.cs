using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of all numbers");
            int sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine("Arerage of all numbers is");
            Console.WriteLine(numbers.Average());
            Console.WriteLine();


            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order:");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("Number in decsending order:");
            var orderByDesc = numbers.OrderByDescending(x => x);
            foreach(var numbers in orderByDesc)
            {
                Console.WriteLine(numbers);
            }

            
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers > 6:");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Only print 4 numbers");
            var print4 = numbers.OrderByDescending(x => x).Take(4);
            foreach(var item in print4)
            {
                Console.WriteLine(item);
            }
            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("Changing index four to 29");
            numbers.SetValue(29, 4);
            foreach (var numbers in orderByDesc)
            {
                Console.WriteLine(numbers);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            var filteredEmployees = employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S');
            var alphabetical = filteredEmployees.OrderBy(x => x.FirstName);
            foreach( var employee in alphabetical)
            {
                Console.WriteLine(employee.FirstName);
            }
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var filteredEmployees2 = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);

            foreach( var employee in filteredEmployees2)
            {
                Console.WriteLine(employee.Age);
                Console.WriteLine(employee.FullName);
                
                Console.WriteLine();
            }


            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var years = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine("Total years of experience:");
            Console.WriteLine(years);
            var average = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine("Arerage years of experience:");
            Console.WriteLine(average);




            //TODO: Add an employee to the end of the list without using employees.Add()
            var newEmployee = new Employee()
            {
                FirstName = "Ana",
                LastName = "McQueen",
                YearsOfExperience = 15,
                Age = 42

            };
            employees.Append(newEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));





            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
