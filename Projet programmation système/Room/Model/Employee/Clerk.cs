using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room.Model
{
    class Clerk
    {
        private Clerk INSTANCE;

        private Clerk()
        {

        }

        public Clerk GetInstance()
        {
            return this;
        }

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
        }
    }
}
