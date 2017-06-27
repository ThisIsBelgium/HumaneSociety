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
            Console.WriteLine("Enter age");
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
            Console.Clear();
            string Gender;
            Console.WriteLine("Enter gender");
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
            Console.WriteLine(name + " is this the correct name?(yes/no)");
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
            Console.WriteLine(housing + " is this correct?(yes/no)");
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
            Console.Clear();
            Console.WriteLine(price + " is this correct?(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetPrice();
            }
            return price;

        }
        public static int GetFoodAmount()
        {
            Console.Clear();
            int foodAmount;
            Console.WriteLine("How much food per week?");
            foodAmount = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(foodAmount + " is this correct?(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetFoodAmount();
            }
            return foodAmount;               
        }
        public static string GetFoodType()
        {
            Console.Clear();
            string foodType;
            Console.WriteLine("What type of food?");
            foodType = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(foodType + " is this correct?(yes/no)");
            string resubmitSelection = Console.ReadLine();
            if (resubmitSelection == "no")
            {
                GetFoodAmount();
            }
            return foodType;
        }
        public static bool UpdateShots()
        {
            bool hasShots = false;
            Console.WriteLine("Give this animal its shots?(yes/no)");
            string shotSelection = Console.ReadLine();
            if (shotSelection == "yes")
            {
                hasShots = true;
            }
            return hasShots;
        }
        public static bool UpdateAdoptionStatus()
        {
            bool adoptionStatus = false;
            Console.WriteLine("Is this animal being adopted today?(yes/no)");
            string adoptionSelection = Console.ReadLine();
            if(adoptionSelection == "yes")
            {
                adoptionStatus = true;
            }
            return adoptionStatus;
        }
        public static int GetMoney(int cost)
        {
            Console.WriteLine("amount to be paid: " + cost +"\n" + "press enter when paymeny is submitted");
            Console.ReadLine();
            return cost;
        }
        public static string GetSpecies()
        {
            Console.Clear();
            string species;
            Console.WriteLine("Enter the breed or species");
            species = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(species + " is this correct?(yes/no)");
            string speciesSelection = Console.ReadLine();
            if(speciesSelection == "no")
            {
                GetSpecies();
            }
            return species;
        }
        public static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Humane Society app what would you like to do" + "\n" + "1.Add a new animal" + "\n" +"2.Add a new adopter" + "\n" + "3.Update exisiting animal" + "\n" + "4.Search for animals" + "\n" + "5.Import CSV" +  "\n" + "Select number next to your choice");
            int selection = Convert.ToInt32(Console.ReadLine());
            return selection;
        }
    }
}
