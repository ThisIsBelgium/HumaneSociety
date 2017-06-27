using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyFinal
{
    static class UI
    {
        public static int GetAge()
        {
            Console.Clear();
            int Age;
            Console.WriteLine("Enter your age");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(Age + " is this correct?(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetAge();
            }
            return Age;
        }
        public static int GetWeight()
        {
            Console.Clear();
            int weight;
            Console.WriteLine("Enter the weight");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(weight + " is this correct?(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetAge();
            }
            return weight;
        }
        public static string GetAnimalType()
        {
            Console.Clear();
            string type;
            Console.WriteLine("Enter the type of animal");
            type = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(type + " is this correct(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetAnimalType();
            }
            return type;
        }
        public static string GetGender()
        {
            string Gender;
            Console.WriteLine("Enter your gender");
            Gender = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Gender + " is this correct(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetGender();
            }
            return Gender;
        }
        public static double GetBudget()
        {
            Console.Clear();
            double Budget;
            Console.WriteLine("Enter your Budget");
            Budget = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(Budget + " is this correct(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetBudget();
            }
            return GetBudget();
        }
        public static bool GetFamily()
        {
            Console.Clear();
            bool Children = default(bool);
            Console.WriteLine("Do you have children?(yes/no)");
            string hasChildren = Console.ReadLine();
            if (hasChildren == "yes")
            {
                Children = true;
            }
            else if (hasChildren == "no")
            {
                Children = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid selection");
                GetFamily();
            }
            return Children;
        }
        public static string GetAnimalSizePreference()
        {
            Console.Clear();
            string SizePreference;
            Console.WriteLine("What size animal are you looking for?(small/medium/large)");
            SizePreference = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(SizePreference + " is this correct?(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetAnimalSizePreference();
            }
            return SizePreference;
        }
        public static string GetAnimalTypePreference()
        {
            Console.Clear();
            string adopterTypePreference;
            Console.WriteLine("What type of animal are you looking for?(dog/cat/small animal/reptile)");
            adopterTypePreference = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(adopterTypePreference + " is this correct?(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetAnimalSizePreference();
            }
            return adopterTypePreference;
        }
        public static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?" + "\n" +"1.Add new animal" + "\n" + "2.Adoption process" + "\n" + "3.Give shops" + "\n" + "4.Add adopter profile" + "\n" + "Search animals" + "\n" + "Choose the number next to your choice");
            int selection=Convert.ToInt32(Console.ReadLine());
            return selection;
        }
        public static string GetAdopterName()
        {
            Console.Clear();
            string adopterName;
            Console.WriteLine("Enter your first name");
            adopterName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            adopterName += Console.ReadLine();
            Console.Clear();
            Console.WriteLine(adopterName + " is this the correct name?(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetAdopterName();
            }
            return adopterName;
        }
        public static string GetName()
        {
            Console.Clear();
            string name;
            Console.WriteLine("Enter animal name");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(name + " is this the correct name(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetName();
            }
            return name;
        }
        public static string GetHousing()
        {
            Console.Clear();
            string housing;
            Console.WriteLine("Enter type of house");
            housing = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(housing + " is this correct(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if(resubmitSelection == "no")
            {
                GetHousing();
            }
            return housing;
        }
        public static int GetPrice()
        {
            Console.Clear();
            int price;
            Console.WriteLine("Set the price of the animal");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(price + " is this correct(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetPrice();
            }
            return price;

        }
        public static string GetFoodAmount()
        {
            Console.Clear();
            string foodAmount;
            Console.WriteLine("How much food per week?");
            foodAmount = Console.ReadLine();
            Console.WriteLine(foodAmount + " is this correct(yes/no)");
            string resumbitSelection = Console.ReadLine();
            if (resumbitSelection == "no")
            {
                GetFoodAmount();
            }
            return foodAmount;               
        }

    }
}
