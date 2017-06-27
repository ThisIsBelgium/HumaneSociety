using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyFinal
{
    public class HumaneSociety
    {
        int[] rooms = new int[45];
        HumaneSocietyDbDataContext newDB = new HumaneSocietyDbDataContext();
        public void AddAnimal()
        {
            Animal newAnimal = new Animal();
            newDB.Animals.InsertOnSubmit(newAnimal);
            newDB.SubmitChanges();
        }
        public void AddAdopter()
        {
            Adopter newAdopter = new Adopter();
            newDB.Adopters.InsertOnSubmit(newAdopter);
            newDB.SubmitChanges();
        }
        public void AnimalSelect(string)
        {
           
        }
    }
}

