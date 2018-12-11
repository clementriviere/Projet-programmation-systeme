<<<<<<< HEAD
﻿using RoomWPF.Model.Client;
using RoomWPF.Model.Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> thomas

namespace Room.Model
{
    class Waiter
    {
<<<<<<< HEAD
        private BackgroundWorker bgw = new BackgroundWorker();

        private List<IClient> clients;
        private Command command;

        public Waiter()
        {
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;

            bgw.RunWorkerAsync();
        }

        public void ServeClient(List<IClient> clients)
        {
           
        }

        public void PutBreadAndWater()
        {
            Console.WriteLine("The waiter put the bread and the water on the table.");
        }

        public void ClearTable(List<IClient> client)
        {
            Console.WriteLine("The waiter clear the table.");
        }
=======
        public Waiter()
        {

        }

        public void ServeClient(List<Client> clients)
        {

        }

        public void ClearTable(Table table)
        {

        }

        /*public List<IElement> PutDishInDirtyStock(IElement element)
        {
          return null; A changer
        }
        */

        public void HelpOtherWaiter(Waiter waiter)
        {

        }

        /*public void PutBreadAndWater(Ingredient bread, IElement water, Table table)
        {

        }*/

        /*public List<IKitchen> WaitFood(List<IKitchen> dishes)
        {

        }*/
>>>>>>> thomas
    }
}
