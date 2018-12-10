using Projet_programmation_système.Kitchen.Model.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_programmation_système.Kitchen.Mode
{
    class HeadCook
    {
        private HeadCook INSTANCE;

        //Implémenter Singleton

        private HeadCook()
        {

        }

        public HeadCook getInstance()
        {
            return this;
        }

        public List<Recipe> DivideTask(Recipe recipe)
        {
            /* A changer */ return null; /* A changer */
        }

        public Recipe CheckStockAndDeleteDish()
        {
            CheckStock();
            DeleteDish();

            /* A changer */ return null; /* A changer */
        }

        private void CheckStock()
        {

        }

        private void DeleteDish()
        {

        }
    }
}
