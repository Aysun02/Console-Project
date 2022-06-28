using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoleType { get; set; }
        public DateTime Birtdate { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
       
        public Employee()
        {
            int _idEmployee = 1;
            _idEmployee++;
            Id = _idEmployee;
        }
        public static void IsPasswordCorrect()
        {

        parol:
            Helper.Print("Please input Password:", ConsoleColor.Green);
            string parol = Console.ReadLine();
            char[] specialChar = { '_', '.', '|' };
            foreach (char symbols in specialChar)
            {
                if (parol.Contains(symbols))
                {
                    Helper.Print("Add  Symbol!", ConsoleColor.Red);
                    goto parol;
                }
                if (parol.Length < 5)
                {
                    Helper.Print("Please input long password!", ConsoleColor.Red);
                    goto parol;
                }
                if (!parol.Any(char.IsUpper))
                {
                    Helper.Print("Please add upper cases in password!", ConsoleColor.Red);
                    goto parol;
                }
                if (!parol.Any(char.IsNumber))
                {
                    Helper.Print("Please add digits to your password!", ConsoleColor.Red);
                    goto parol;
                }
            }
        }
       
    }
}
