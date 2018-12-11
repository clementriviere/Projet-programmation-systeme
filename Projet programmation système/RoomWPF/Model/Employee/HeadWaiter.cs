using RoomWPF.Model.Client;
using RoomWPF.Model.Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Room.Model
{
    class HeadWaiter
    {
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
        }

        public void HelpOtherHeadWaiter(HeadWaiter headwaiter)
        {
            //How to implement ?
        }
    }
}
