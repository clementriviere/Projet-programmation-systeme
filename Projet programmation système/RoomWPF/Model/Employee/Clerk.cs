<<<<<<< HEAD
﻿using RoomWPF.Model.Client;
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
    class Clerk
    {
<<<<<<< HEAD
        private static Clerk INSTANCE;
        private BackgroundWorker bgw = new BackgroundWorker();
       
        private Clerk()
        {
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;

            bgw.RunWorkerAsync();
=======
        private Clerk INSTANCE;

        private Clerk()
        {

>>>>>>> thomas
        }

        public Clerk GetInstance()
        {
            return this;
        }

<<<<<<< HEAD
        public void ServeBreadAndDrinks(List<IClient> clients)
        {
            Console.WriteLine("The clerk supply the client in bread and drinks");
            if (CheckIfClientNeedSomething(clients))
            {

            }
            Thread.Sleep(1000);
        }

        public bool CheckIfClientNeedSomething(List<IClient> clients)
        {
            foreach(IClient c in clients)
            {
                if (c.NeedBreadAndDrinks)
                {
                    return true;
                }
            }

            return false;
        }

        public void HelpWaiter()
        {
            //How to implement ?
=======
        public void ServeBreadAndDrinks(ClientThread client)
        {
            //Check si on apporte pas à la table plutôt
        }

        public void CheckIfClientNeedSomething(Client client)
        {

        }

        public Waiter BecomeWaiter()
        {
            return null; //A changer
>>>>>>> thomas
        }
    }
}
