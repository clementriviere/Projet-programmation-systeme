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
    class Butler
    {
<<<<<<< HEAD
        private static Butler INSTANCE;
        private BackgroundWorker bgw = new BackgroundWorker();

=======
        private Butler INSTANCE;
>>>>>>> thomas

        public Butler GetInstance()
        {
            return this;
        }

<<<<<<< HEAD
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
=======
        public void CustomerReception()
        {

        }

        public Table TableAttribution()
        {
            /* A changer */ return null; /* A changer */
        }

        public HeadWaiter CallHeadWaiter()
        {
            /* A changer */ return null; /* A changer */
        }
    }
}
>>>>>>> thomas
