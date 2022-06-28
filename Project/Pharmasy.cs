using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Pharmasy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinSalary { get; set; }
        public static int Budget { get; set; }
        public string Location { get; set; }
        public static Employee[] Employees;

        public Pharmasy()
        {

            Employees = new Employee[0];
        }
        public static void AddEmployee(Employee employee)
        {
            Pharmasy pharmasy = new Pharmasy();
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }
        public static void EmployeeDelete()
        {
            Helper.Print("Please enter the Employee name which you are searching for Remove:", ConsoleColor.Blue);
            string employeename = Console.ReadLine();
            foreach (var item in Employees)
            {
                Helper.Print($"{item.Name}---{item.Id}----{item.RoleType} ", ConsoleColor.Yellow);
            }
        ID:
            Helper.Print("Please enter the Employee ID", ConsoleColor.Blue);
            int inputemployeeID = int.Parse(Console.ReadLine());
            if (inputemployeeID == 0)
            {
                Helper.Print($"{employeename} : Don't found", ConsoleColor.Red);
                goto ID;
            }
            Helper.Print("Please enter correct id", ConsoleColor.Red);
            goto ID;
            foreach (var employee in Employees)
            {
                Console.WriteLine(employee);
            }
            int indexToRemove = inputemployeeID;
            Employees = Employees.Where((source, index) => index != indexToRemove).ToArray();
            Console.WriteLine("Array after deleting");

            foreach (var employyee in Employees)
            {
                Console.WriteLine(employyee);
                {
                    Helper.Print($"{inputemployeeID}: employee is deleted", ConsoleColor.Green);
                }
                break;
            }
        }
        public static void EmployeeEdit()
        {
            Helper.Print("Please enter the Employee name which you are searching for Edit:", ConsoleColor.Blue);
            string emplname = Console.ReadLine();
            foreach (var item in Employees)
            {
                Helper.Print($"{item.Name}---{item.Id}----{item.RoleType} ", ConsoleColor.Yellow);
            }
        ID:
            Helper.Print("Please enter the Employee ID", ConsoleColor.Blue);
            int inputempId = int.Parse(Console.ReadLine());
            if (inputempId == 0)
            {
                Helper.Print($"{emplname} : Don't found", ConsoleColor.Red);
                goto ID;
            }
            Helper.Print("Please enter correct id", ConsoleColor.Red);
            goto ID;
            foreach (var employee in Employees)
            {
                Console.WriteLine(employee);
            }
            int indexToRemove = inputempId;
            Employees = Employees.Where((source, index) => index != indexToRemove).ToArray();
            Console.WriteLine("Array after deleting");

            foreach (var empl in Employees)
            {
                Console.WriteLine(empl);
                {
                    Helper.Print($"{emplname}: employee is deleted", ConsoleColor.Green);
                }
                break;
            }
        }
    }
 }


