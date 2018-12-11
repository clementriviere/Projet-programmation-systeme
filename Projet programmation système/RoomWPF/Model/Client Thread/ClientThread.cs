using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Room.Model
{
    class ClientThread
    {
        private BackgroundWorker bgw = new BackgroundWorker();

        public ClientThread()
        {
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;

            bgw.RunWorkerAsync();
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        /*public List<IKitchen> Command(int time)
        {
            return null; A changer
        }*/

        public void Pay(int time) //Voir pour le time
        {
            Console.WriteLine("The client is paying");
        }

        public Waiter CallWaiter()
        {
            return null; /*A changer */
        }

        public void ChooseDish(int coef) //public void ChooseDish(Recipe recipe, int coef)
        {
            Console.WriteLine("The client chose : INSERT RECIPE");
            Thread.Sleep(1000);
        }

        public void Eat(int coef)
        {

        }
    }
}
