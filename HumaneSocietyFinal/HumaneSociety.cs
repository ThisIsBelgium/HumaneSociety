using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HumaneSocietyFinal
{
    public class HumaneSociety
    {
        int[] rooms = new int[45];
        HumaneSocietyDbDataContext newDB = new HumaneSocietyDbDataContext();
        public void Run()
        {
            int selection = UI.MainMenu();
            if (selection == 1)
            {
                AddAnimal();
            }
            else if (selection == 2)
            {
                AddAdopter();
            }
            else if (selection == 3)
            {
                UpdateAnimal();
            }
            else if (selection == 4)
            {
                SearchAnimals();
            }
            else if (selection == 5)
            {
                ImportAnimalCSV();
            }
            else
            {
                Console.WriteLine("choose a valid selection");
                Run();
            }
        }
        public void AddAnimal()
        {
            int currentAnimal = 1;
            Animal newAnimal = new Animal();
            var roomQuery = from Animal in newDB.Animals
                            select Animal;
            foreach (var animal in roomQuery)
            {
                currentAnimal++;
            }
            if (currentAnimal > rooms.Length)
            {
                Console.WriteLine("Unable to add animal society full");
                return;
            }
            newAnimal.RoomNumber = currentAnimal;
            newAnimal.Age = UI.GetAge();
            newAnimal.AnimalWeight = UI.GetWeight();
            newAnimal.AnimalType = UI.GetAnimalType();
            newAnimal.HasShots = false;
            newAnimal.Name = UI.GetName();
            newAnimal.Cost = UI.GetPrice();
            newAnimal.Adopted = false;
            newAnimal.Gender = UI.GetGender();
            newAnimal.AmountOfFood = UI.GetFoodAmount();
            newAnimal.TypeOfFood = UI.GetFoodType();
            newAnimal.AnimalSpecies = UI.GetSpecies();
            newDB.Animals.InsertOnSubmit(newAnimal);
            newDB.SubmitChanges();
            currentAnimal++;
            Console.Clear();
            Console.WriteLine("Would you like to continue?(yes/no)");
            string selection = Console.ReadLine();
            if (selection == "yes")
            {
                Run();
            }
        }
        public void AddAdopter()
        {
            Adopter newAdopter = new Adopter();
            newDB.Adopters.InsertOnSubmit(newAdopter);
            newDB.SubmitChanges();
            Console.Clear();
            Console.WriteLine("Would you like to continue?(yes/no)");
            string selection = Console.ReadLine();
            if (selection == "yes")
            {
                Run();
            }
        }
        private int AnimalSelect(string name)
        {
            int selectedID = 0;
            var nameQuery = from Animal in newDB.Animals
                            where Animal.Name == name
                            select Animal;
            foreach (var animal in nameQuery)
            {
                Console.WriteLine(animal.ID + " " + animal.Name);

            }
            if (nameQuery.Count() == 1)
            {
                foreach (var animals in nameQuery)
                {
                    selectedID = animals.ID;
                }
            }
            else if (nameQuery.Count() > 1)
            {
                Console.WriteLine("Select the ID number of the animal");
                int ID = Convert.ToInt32(Console.ReadLine());
                var IDQuery = from animals in newDB.Animals
                              where animals.ID == ID
                              select animals;
                foreach (var animals in IDQuery)
                {
                    selectedID = animals.ID;
                }
            }
            return selectedID;
        }
        public void UpdateAnimal()
        {
            string name = UI.GetName();
            int id = AnimalSelect(name);
            Console.Clear();
            var selectedAnimal = from Animal in newDB.Animals
                                 where Animal.ID == id
                                 select Animal;
            foreach (var animal in selectedAnimal)
            {
                Console.WriteLine("animal name: " + animal.Name + "\n" + "animal has shots:" + animal.HasShots + "\n" + "animal is adopted:" + animal.Adopted + "\n" + "animal costs:" + animal.Cost);
                animal.HasShots = UI.UpdateShots();
                animal.Adopted = UI.UpdateAdoptionStatus();
                if (animal.Adopted == true)
                {
                    animal.Cost -= UI.GetMoney(Convert.ToInt32(animal.Cost));
                }
            }
            newDB.SubmitChanges();
            Console.Clear();
            Console.WriteLine("Would you like to continue?(yes/no)");
            string selection = Console.ReadLine();
            if (selection == "yes")
            {
                Run();
            }
        }
        public void SearchAnimals()
        {
            List<Animal> animalSearch = new List<Animal>();
            Console.Clear();
            string typeToSearch = UI.GetAnimalType();
            var typeQuery = from animal in newDB.Animals
                            where animal.AnimalType == typeToSearch
                            select animal;
            foreach (var animal in typeQuery)
            {
                Console.WriteLine("Name:" + animal.Name + " " + "Species:" + animal.AnimalSpecies + " " + "Age:" + animal.Age + " " + "Gender:" + animal.Gender);
                animalSearch.Add(animal);
            }
            Console.WriteLine("Would you like to refine your search?(yes/no)");
            string refineSelection = Console.ReadLine();
            if (refineSelection == "yes")
            {
                RefinedSearch(animalSearch);
            }
        }
        public void RefinedSearch(List<Animal> search)
        {
            Console.Clear();
            Console.WriteLine("What would you like to refine your search by?(species/age/gender)");
            string refineSelection = Console.ReadLine();
            if (refineSelection == "species")
            {
                string speciesSelection = UI.GetSpecies();
                foreach (Animal animal in search)
                {
                    if (speciesSelection != animal.AnimalSpecies)
                    {
                        search.Remove(animal);
                    }
                    else
                    {
                        Console.WriteLine("Name:" + animal.Name + " " + "Species:" + animal.AnimalSpecies + " " +"Age:" + animal.Age + " " + "Gender:" + animal.Gender);
                    }
                }
                Console.WriteLine("Would you like to refine your search?(yes/no)");
                string refineChoice = Console.ReadLine();
                if (refineChoice == "yes")
                {
                    RefinedSearch(search);
                }
                else if (refineChoice == "no")
                {
                    Console.Clear();
                    Console.WriteLine("Would you like to continue?(yes/no)");
                    string selection = Console.ReadLine();
                    if (selection == "yes")
                    {
                        Run();
                    }
                }

            }
            else if (refineSelection == "age")
            {
                int ageSelection = UI.GetAge();
                foreach (Animal animal in search)
                {
                    if (ageSelection != animal.Age)
                    {
                        search.Remove(animal);
                    }
                    else
                    {
                        Console.WriteLine("Name:" + animal.Name + " " + "Species:" + animal.AnimalSpecies + " " + "Age:" + animal.Age + " " + "Gender:" + animal.Gender);
                    }
                }
                Console.WriteLine("Would you like to refine your search?(yes/no)");
                string refineChoice = Console.ReadLine();
                if (refineChoice == "yes")
                {
                    RefinedSearch(search);
                }
                else if (refineChoice == "no")
                {
                    Console.Clear();
                    Console.WriteLine("Would you like to continue?(yes/no)");
                    string selection = Console.ReadLine();
                    if (selection == "yes")
                    {
                        Run();
                    }
                }
            }
            else if (refineSelection == "gender")
            {
                string genderSelection = UI.GetGender();
                foreach (Animal animal in search)
                {
                    if (genderSelection != animal.Gender.Trim())
                    {
                        search.Remove(animal);
                    }
                    else
                    {
                        Console.WriteLine("Name:" + animal.Name + " " + "Species:" + animal.AnimalSpecies + " " + "Age:" + animal.Age + " " + "Gender:" + animal.Gender);
                    }
                }
                Console.WriteLine("Would you like to refine your search?(yes/no)");
                string refineChoice = Console.ReadLine();
                if (refineChoice == "yes")
                {
                    RefinedSearch(search);
                }
                else if (refineChoice == "no")
                {
                    Console.Clear();
                    Console.WriteLine("Would you like to continue?(yes/no)");
                    string selection = Console.ReadLine();
                    if (selection == "yes")
                    {
                        Run();
                    }
                }
            }
        }
        public void ImportAnimalCSV()
        {
            Console.Clear();
            Console.WriteLine("enter file path");
            string filepath = Console.ReadLine();
            var query = from line in File.ReadLines(filepath)
                        let csvLines = line.Split(';')
                        from csvLine in csvLines
                        where !String.IsNullOrWhiteSpace(csvLine)
                        let data = csvLine.Split(',')
                        select new
                        {
                            Age = data[0],
                            AnimalWeight = data[1],
                            AnimalType = data[2],
                            Name = data[3],
                            Cost = data[4],
                            Gender = data[5],
                            AmountOfFood = data[6],
                            TypeOfFood = data[7],
                            AnimalSpecies = data[8]


                        };
            foreach(var animal in query)
            {
                Animal newAnimal = new Animal();
                newAnimal.Age = Convert.ToInt32(animal.Age);
                newAnimal.AnimalWeight = Convert.ToInt32(animal.AnimalWeight);
                newAnimal.AnimalType = animal.AnimalType;
                newAnimal.Name = animal.Name;
                newAnimal.Cost = Convert.ToInt32(animal.Cost);
                newAnimal.Gender = animal.Gender;
                newAnimal.AmountOfFood = Convert.ToInt32(animal.AmountOfFood);
                newAnimal.TypeOfFood = animal.TypeOfFood;
                newAnimal.AnimalSpecies = animal.AnimalSpecies;
                newDB.Animals.InsertOnSubmit(newAnimal);
                newDB.SubmitChanges();
            }
        }

    }
}


