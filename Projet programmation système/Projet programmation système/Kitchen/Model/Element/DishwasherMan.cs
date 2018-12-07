using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_programmation_système.Kitchen.Mode
{
    class DishwasherMan
    {
        private DishwasherMan INSTANCE;
        //Implémenter Singleton

        private DishwasherMan()
        {

        }

        public DishwasherMan GetInstance()
        {
            return this;
        }

        public void WashCookEquipement(IEquipement kitchenEquipement)
        {

        }

        public void WashRoomEquipement(IEquipement roomEquipement)
        {

        }

        public void WashEquipement(IEquipement equipement)
        {

        }

        public void FillDishwasher(List<IEquipement> dirtyEquipements)
        {

        }

        public void FillWashingMachine(List<IEquipement> dirtyEquipements)
        {

        }

        public List<IEquipement> EmptyDishWasher()
        {
            /*A changer*/ return null; /*A changer*/
        }

        public List<IEquipement> EmptyWashingMachine()
        {
            /*A changer*/ return null; /*A changer*/
        }
    }
}
