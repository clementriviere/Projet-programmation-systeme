using RoomWPF.Model.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Room.Model
{
    class Butler
    {
        private static Butler INSTANCE;
        private BackgroundWorker bgw = new BackgroundWorker();


        public Butler GetInstance()
        {
            return this;
        }

        public Butler()
        {
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;

            bgw.RunWorkerAsync();
        }

    public void CustomerReception(List<IClient> client)
    {
        Console.WriteLine("The Butler is welcoming the client.");
        Thread.Sleep(5000);
        TableAttribution();
    }

    public void TableAttribution()
    {
        if (Room.CAPACITY_ROOM < 1)
        {
            Console.WriteLine("The room is full, the client is waiting");
            Thread.Sleep(5000);
            TableAttribution();
        }
    }

    public void CallHeadWaiter()
    {
        Console.WriteLine("The Butler is calling a head waiter.");
    }
}
}
