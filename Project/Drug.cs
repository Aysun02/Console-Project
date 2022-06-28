using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DrugType { get; set; }
        public int Count { get; set; }
        public int PurchasePrice { get; set; }
        public int SalePrice { get; set; }
        public static Drug[] Medicines;

        public Drug(int _durgId)
        {
            _durgId++;
            Id = _durgId;
        }
        public static void AddDrug(Drug drug)
        {
            Drug drug1 = new Drug(1);
            Array.Resize(ref Medicines, Medicines.Length + 1);
            Medicines[Medicines.Length - 1] = drug;
        }
        public static void Sell(string name, int count)
        {

            foreach (var item in Medicines)
            {
                if (item.Name == name)
                {
                    if (item.Count < count)
                    {
                        if (item.Count != 0)
                        {
                            Console.WriteLine($"Just we have {item.Count} , Do you want? yes or no");
                            string answer = Console.ReadLine();
                            if (answer == "yes")
                            {
                                Sell(name, item.Count);
                            }
                        }
                        else if (item.Count == 0)
                        {
                            Console.WriteLine($"Unfortunately {name} doesnt exist");
                        }

                    }
                    else
                    {
                        item.Count -= count;
                        Pharmasy.Budget += item.SalePrice * count;
                    }
                }
            }
        }
        public static void RemoveDrug()
        {
            Helper.Print("Please enter the drug name which you are searching for Remove:", ConsoleColor.Blue);
            string drugname = Console.ReadLine();
            foreach (var item in Medicines)
            {
                Helper.Print($"{item.Name}---{item.Id}----{item.DrugType} ", ConsoleColor.Yellow);
            }
        ID:
            Helper.Print("Please enter the drug ID", ConsoleColor.Blue);
            int inputdrugId = int.Parse(Console.ReadLine());
            if (inputdrugId == 0)
            {
                Helper.Print($"{drugname} : Don't found", ConsoleColor.Red);
                goto ID;
            }
            Helper.Print("Please enter correct id", ConsoleColor.Red);
            goto ID;
            foreach (var drug in Medicines)
            {
                Console.WriteLine(drug);
            }
            int indexToRemove = inputdrugId;
            Medicines = Medicines.Where((source, index) => index != indexToRemove).ToArray();
            Console.WriteLine("Array after delet");

            foreach (var drug in Medicines)
            {
                Console.WriteLine(drug);
                {
                    Helper.Print($"{drugname}: employee is deleted", ConsoleColor.Green);
                }
                break;
            }
        }
        public static void EditDrug()
        {

            Helper.Print("Please enter the drug name which you are searching for Remove:", ConsoleColor.Blue);
            string drugname = Console.ReadLine();
            foreach (var item in Medicines)
            {
                Helper.Print($"{item.Name}---{item.Id}----{item.DrugType} ", ConsoleColor.Yellow);
            }
        ID:
            Helper.Print("Please enter the drug ID", ConsoleColor.Blue);
            int inputdrugId = int.Parse(Console.ReadLine());
            if (inputdrugId == 0)
            {
                Helper.Print($"{drugname} : Don't found", ConsoleColor.Red);
                goto ID;
            }
            Helper.Print("Please enter correct id", ConsoleColor.Red);
            goto ID;

            foreach (var drug in Medicines)
            {
                Console.WriteLine(drug);
            }
            int indexToRemove = inputdrugId;
            Medicines = Medicines.Where((source, index) => index != indexToRemove).ToArray();
            Console.WriteLine("Array after delet");

            foreach (var drug in Medicines)
            {
                Console.WriteLine(drug);
                {
                    Helper.Print($"{drugname}: employee is deleted", ConsoleColor.Green);
                }
                break;
            }
        }
    }
}
            
