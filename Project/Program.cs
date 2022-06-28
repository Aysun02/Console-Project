using System;

namespace ConsoleApp33
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Pharmasy
            Pharmasy Chemist = new Pharmasy();
            Helper.Print("Please Add Pharmasy Name", ConsoleColor.Blue);
            Chemist.Name = Console.ReadLine();
            Helper.Print("Please Choose your Pharmasy's Minimum Salary", ConsoleColor.Blue);
            Chemist.MinSalary = int.Parse(Console.ReadLine());
            Helper.Print("Please input Pharmasy's Budget value", ConsoleColor.Blue);
            Pharmasy.Budget = int.Parse(Console.ReadLine());
            Helper.Print("Please input Pharmay's address", ConsoleColor.Blue);
            Chemist.Location = Console.ReadLine();
            Helper.Print("Your Pharmacy is created successfully!", ConsoleColor.DarkGreen);
            #endregion
            #region DefaultEmployee
            Employee admin = new Employee()
            {
                Name = "Aysun",
                Surname = "Huseynli",
                RoleType = "Admin",
                UserName = "huseynli02",
                Password = "Huseynli_02",
                Salary = 2500

            };
            Pharmasy.AddEmployee(admin);

            Helper.Print("Login, please enter your Username and Password correctly!", ConsoleColor.Green);

        usr:
            Helper.Print("Username:", ConsoleColor.Magenta);
            string username = Console.ReadLine();
            if (username != admin.UserName)
            {
                Helper.Print("Please check your username and input it correct!", ConsoleColor.Red);
                goto usr;
            }
        password:
            Helper.Print("Password:", ConsoleColor.Magenta);
            string password = Console.ReadLine();
            if (password != admin.Password)
            {
                Helper.Print("Please input Password correct!", ConsoleColor.Red);
                goto password;
            }
            #endregion
            #region Admin
            if (admin.RoleType == "Admin")
            {
                Helper.Print("1.Admin Panel     2.Satis et     3.Melumatlarimi yenile", ConsoleColor.DarkYellow);
                Helper.Print("Please choose number from Menu:", ConsoleColor.Green);
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                    #region AdminPanel
                        Helper.Print("Hello, you have logged in to the admin panel!", ConsoleColor.DarkYellow);
                    panel:
                        Helper.Print("Please select an operation to perform: " +
                            "1.Add Employee     2.Add Drug     3.Remove Drug" +
                            "     4.Edit Drug     5.Remove Employee     6.Edit Employee", ConsoleColor.DarkYellow);
                        string menu = Console.ReadLine();
                        switch (menu)
                        {
                            #region AddEmployee
                            case "1":
                                Employee includedemployee = new Employee();
                                Helper.Print("Please input Employee Name:", ConsoleColor.Green);
                                string ename = Console.ReadLine();
                                Helper.Print("Please input Employee Surname:", ConsoleColor.Green);
                                string esurname = Console.ReadLine();
                            inputeddate:
                                Helper.Print("Please input Emloyee's BirthDate:", ConsoleColor.Green);
                                string birthdate = Console.ReadLine();
                                bool isParsabledate = DateTime.TryParse(birthdate, out DateTime newbirthdate);
                                if (!isParsabledate)
                                {
                                    Helper.Print("Inputed Date is not correct form!", ConsoleColor.Red);
                                    goto inputeddate;
                                }
                                string role = Console.ReadLine();
                            user:
                                Helper.Print("Please input Username:", ConsoleColor.Green);
                                string inputedusername = Console.ReadLine();
                                if (inputedusername == includedemployee.UserName)
                                {
                                    Helper.Print("Please include unique Username!", ConsoleColor.Red);
                                }
                                if (admin.UserName == inputedusername)
                                {
                                    Helper.Print("This Username is used, please choose other one! ", ConsoleColor.Red);
                                    goto user;
                                }
                                Employee.IsPasswordCorrect();
                            salary:
                                Helper.Print("Input Salary:", ConsoleColor.Green);
                                int Salary = int.Parse(Console.ReadLine());
                                if (Salary < Chemist.MinSalary)
                                {
                                    Helper.Print("Your Salary is lower than Minimum Salary!", ConsoleColor.Red);
                                    goto salary;
                                }
                                else if (Salary > Pharmasy.Budget)
                                {
                                    Helper.Print("Please enter correct salary value!", ConsoleColor.Red);
                                    goto salary;
                                }
                                Pharmasy.AddEmployee(includedemployee);
                                Helper.Print("Employee Added Successfully!", ConsoleColor.DarkYellow);
                                goto panel;
                            #endregion
                            #region AddDrug
                            case "2":
                                Drug addedDrug = new Drug(1);
                                Helper.Print("Please input Drug Name:", ConsoleColor.Green);
                                string Name = Console.ReadLine();
                                Helper.Print("Drug's type:", ConsoleColor.Green);
                                string type = Console.ReadLine();
                                if (type == addedDrug.DrugType)
                                {
                                    Helper.Print("Your have this type of Drug, you can't add this too!", ConsoleColor.Red);
                                    goto panel;
                                }
                                Helper.Print("Add Drug's count:", ConsoleColor.Green);
                                int drugCount = int.Parse(Console.ReadLine());
                                Helper.Print("Input drug's Purchase Price:", ConsoleColor.Green);
                                int purchase = int.Parse(Console.ReadLine());
                                int Totalprice;
                                Totalprice = drugCount * purchase;
                                Console.WriteLine(Totalprice);
                                if (Totalprice > Pharmasy.Budget)
                                {
                                    Helper.Print("You cannot take this medicine because you do not have enough money!", ConsoleColor.Red);
                                    goto panel;
                                }
                                Helper.Print("Please input drug's Sale Price", ConsoleColor.Green);
                                int sale = int.Parse(Console.ReadLine());
                                Drug.AddDrug(addedDrug);
                                Helper.Print("Drug Added Successfully!", ConsoleColor.DarkYellow);
                                goto panel;
                            #endregion
                            #region RemoveDrug
                            case "3":
                                Drug.RemoveDrug();
                                break;
                            #endregion region
                            #region EditDrug
                            case "4":
                                Drug.EditDrug();
                                break;
                            #endregion
                            #region RemoveEmployee
                            case "5":
                                Pharmasy.EmployeeDelete();
                                break;
                            #endregion
                            #region EditEmployee
                            case "6":
                                Pharmasy.EmployeeEdit();
                                break;
                                #endregion

                        }
                        break;
                    #endregion
                    #region Sell
                    case "2":
                        Helper.Print("Please input Drug's name:", ConsoleColor.Green);
                        string name = Console.ReadLine();
                        Helper.Print("Please input Drug's count:", ConsoleColor.Green);
                        int count = int.Parse(Console.ReadLine());
                        static void SellProduct()
                        {
                            Drug drug = new Drug(1);
                            Helper.Print("How much do you want?", ConsoleColor.Cyan);
                            string name = Console.ReadLine();

                        SellCountInput:
                            Console.Write("How much do you want? ");
                            bool isSellCountParsable = int.TryParse(Console.ReadLine(), out int sellCount);
                            if (!isSellCountParsable)
                            {
                                Helper.Print("Dont correct , Please try again", ConsoleColor.DarkRed);
                                goto SellCountInput;
                            }
                            Drug.Sell(name, sellCount);
                        }
                        SellProduct();
                        break;
                    #endregion
                    #region Renew
                    case "3":
                    old:
                        Helper.Print("Please enter your Personal info and change them!", ConsoleColor.Green);
                        Helper.Print("Name:", ConsoleColor.Blue);
                        string oldname = Console.ReadLine();
                        Helper.Print("Surname", ConsoleColor.Blue);
                        string oldsurname = Console.ReadLine();
                        Helper.Print("Username:", ConsoleColor.Blue);
                        string oldusername = Console.ReadLine();
                        Helper.Print("Password", ConsoleColor.Blue);
                        string oldparol = Console.ReadLine();
                        if (oldparol == password & oldsurname == username)
                        {
                        News:
                            Employee newadded = new Employee();
                            Helper.Print("Name:", ConsoleColor.Blue);
                            string newname = Console.ReadLine();
                            Helper.Print("Surname", ConsoleColor.Blue);
                            string newsurname = Console.ReadLine();
                            Helper.Print("Include new UserName:", ConsoleColor.Green);
                            string newusername = Console.ReadLine();
                            Helper.Print("Include new Password:", ConsoleColor.Green);
                            string newparol = Console.ReadLine();
                            if (newparol == oldparol)
                            {
                                Helper.Print("Your previous password doesn't use as new one!", ConsoleColor.Red);
                                goto News;
                            }
                            else if (newusername == oldusername)
                            {
                                Helper.Print("Your previous username doesn't use as new one!", ConsoleColor.Red);
                                goto News;
                            }
                            else
                            {


                                Helper.Print("Your infos changed successfully!", ConsoleColor.DarkBlue);
                                Pharmasy.EmployeeDelete();
                                Pharmasy.AddEmployee(newadded);
                            }
                        }
                        else
                        {
                            Helper.Print("Please include your last infos correct!", ConsoleColor.Red);
                            goto old;
                        }
                        break;
                        #endregion

                }
            }
            #endregion
            #region Staff
            if (admin.RoleType == "Staff")
            {
                Helper.Print("1.Satis et     2.Melumatlari yenile", ConsoleColor.Blue);
                string result = Console.ReadLine();
                switch (result)
                {
                    #region StaffSell
                    case "1":
                        Helper.Print("Please input Drug's name:", ConsoleColor.Green);
                        string name = Console.ReadLine();
                        Helper.Print("Please input Drug's count:", ConsoleColor.Green);
                        int count = int.Parse(Console.ReadLine());
                        static void SellProduct()
                        {
                            Drug drug = new Drug(1);
                            Helper.Print("How much do you want?", ConsoleColor.Cyan);
                            string name = Console.ReadLine();

                        SellCountInput:
                            Console.Write("How much do you want? ");
                            bool isSellCountParsable = int.TryParse(Console.ReadLine(), out int sellCount);
                            if (!isSellCountParsable)
                            {
                                Helper.Print("Dont correct , Please try again", ConsoleColor.DarkRed);
                                goto SellCountInput;
                            }
                            Drug.Sell(name, sellCount);
                        }
                        SellProduct();
                        break;
                    #endregion
                    #region StaffRenew
                    case "2":
                    old:
                        Helper.Print("Please enter your Personal info and change them!", ConsoleColor.Green);
                        Helper.Print("Name:", ConsoleColor.Blue);
                        string oldname = Console.ReadLine();
                        Helper.Print("Surname", ConsoleColor.Blue);
                        string oldsurname = Console.ReadLine();
                        Helper.Print("Username:", ConsoleColor.Blue);
                        string oldusername = Console.ReadLine();
                        Helper.Print("Password", ConsoleColor.Blue);
                        string oldparol = Console.ReadLine();
                        if (oldparol == password & oldsurname == username)
                        {
                        News:
                            Employee newadded = new Employee();
                            Helper.Print("Name:", ConsoleColor.Blue);
                            string newname = Console.ReadLine();
                            Helper.Print("Surname", ConsoleColor.Blue);
                            string newsurname = Console.ReadLine();
                            Helper.Print("Include new UserName:", ConsoleColor.Green);
                            string newusername = Console.ReadLine();
                            Helper.Print("Include new Password:", ConsoleColor.Green);
                            string newparol = Console.ReadLine();
                            if (newparol == oldparol)
                            {
                                Helper.Print("Your previous password doesn't use as new one!", ConsoleColor.Red);
                                goto News;
                            }
                            else if (newusername == oldusername)
                            {
                                Helper.Print("Your previous username doesn't use as new one!", ConsoleColor.Red);
                                goto News;
                            }
                            else
                            {


                                Helper.Print("Your infos changed successfully!", ConsoleColor.DarkBlue);
                                Pharmasy.EmployeeDelete();
                                Pharmasy.AddEmployee(newadded);
                            }
                        }
                        else
                        {
                            Helper.Print("Please include your last infos correct!", ConsoleColor.Red);
                            goto old;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
        }
    }
}
