using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room.Model
{
    class HeadWaiter
    {
        public HeadWaiter()
        {

        }

        public void PlaceClient(Table table) //Comment savoir quel client est assigné ? Nécessaire ?
        {

        }

        public void GiveMenu(Menu menu)
        {

        }

        /*public List<Menu> TakeCommand(List<Recipe> command)
        {
                    Reflechir à une solution pour les recipe, dépendances, references par rapport à l'assembly ???
        }*/

        public void GiveCommandToHeadCook(List<Menu> command)
        {

        }

        public void HelpOtherHeadWaiter(HeadWaiter headwaiter)
        {

        }

        public Table SetUpTable()
        {
            /* A changer */ return null; /* A changer */
        }
    }
}
