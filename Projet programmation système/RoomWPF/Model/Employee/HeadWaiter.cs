<<<<<<< HEAD
﻿using RoomWPF.Model.Client;
using RoomWPF.Model.Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> thomas

namespace Room.Model
{
    class HeadWaiter
    {
<<<<<<< HEAD
        private BackgroundWorker bgw = new BackgroundWorker();

        public HeadWaiter()
        {
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;

            bgw.RunWorkerAsync();
        }

        public void PlaceClient(List<IClient> clients)
        {
            Console.WriteLine("The head waiter is placing the client");
            int cpt = 0;
            foreach(IClient c in clients) { cpt++; }
            Room.CAPACITY_ROOM -= cpt;
            Thread.Sleep(3000);
        }

        public void GiveMenu()
        {
            Console.WriteLine("The head waiter gave the menu to the Client.");
            Thread.Sleep(3000);
        }

        public void TakeCommand()
        {
            Thread.Sleep(3000);
        }

        public void GiveCommandToKitchen(Command command)
        {
            //Send to Socket
=======
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

>>>>>>> thomas
        }

        public void HelpOtherHeadWaiter(HeadWaiter headwaiter)
        {
<<<<<<< HEAD
            //How to implement ?
=======

        }

        public Table SetUpTable()
        {
            /* A changer */ return null; /* A changer */
>>>>>>> thomas
        }
    }
}
