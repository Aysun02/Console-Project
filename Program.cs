using System;

namespace Main_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pharmasy Zeferean = new Pharmasy("Zeferan")
            {
                Id = 1,
            
                Location = "Heyder Eliyev Prospekti",
                Budget = 1000000,
                MinSalary = 500
            };

            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Aysun",
                Surname = "Huseynli",
                RoleType = "Admin",
                Birtdate = "06.09.2003",
                UserName = "AysunHuseynzadeh",
                Password = "Huseynli_02",
                Salary = 2500
            };

            Console.WriteLine("Login, please enter your Username and Password correctly!");
            usr:
            Console.Write("Username:");
            string username = Console.ReadLine();
            if(username != employee.UserName)
            {
                Console.WriteLine("Please check your username and input it correct!");
                goto usr;
            }
            password:
            Console.Write("Password:");
            string password = Console.ReadLine();
                if(password != employee.Password)
                {
                    Console.WriteLine("Please input Password correct!");
                    goto password;
                }
            if(employee.RoleType == "Admin")
            {
                Console.WriteLine("1.Admin Panel");
                Console.WriteLine("2.Satis et");
                Console.WriteLine("Melumatlarimi yenile");
                
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Hello, you have logged in to the admin panel! Please select an operation to perform: " +
                            "1.Add Employee     2.Add Drug     3.Remove Drug" +
                            "     4.Edit Drug     5.Remove Employee     6.Edit Employee");
                        string menu = Console.ReadLine();
                        switch (menu)
                        {
                            case "1":
                                Console.Write("Please input Employee Name:");
                                string ename = Console.ReadLine();
                                Console.Write("Please input Employee Surname:");
                                string esurname = Console.ReadLine();
                                Console.Write("Please input Emloyee's BirthDate:");
                                string birth = DateTime.Now.ToString("dd/MM/yyyy");
                                Console.Write("Please input employee's RoleType:");
                                string role = Console.ReadLine();
                               
                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                            case "6":
                                break;
                        }
                           
                        break;
                        case "2":
                        break;
                    case "3":
                        break;

                }
               

            }
            if(employee.RoleType == "Staff")
            {
                Console.WriteLine("1.Satis et");
                Console.WriteLine("2.Melumatlarimi yenile");
            }
        }
    }
}
