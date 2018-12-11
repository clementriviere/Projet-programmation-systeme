using RoomWPF.Model.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Room.Model
{
    class Clerk
    {
        private static Clerk INSTANCE;
        private BackgroundWorker bgw = new BackgroundWorker();
       
        private Clerk()
        {
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;

            bgw.RunWorkerAsync();
        }

        public Clerk GetInstance()
        {
            return this;
        }

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
        }
    }
}
