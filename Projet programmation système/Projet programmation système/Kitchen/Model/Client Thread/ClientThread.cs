using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Room.Model
{
    //A proper solution I found to have a look-alike enum in C#.
    public class State
    {
        private State(string value) { Value = value; }
        public string Value { get; set; }

        public static State Waiting { get { return new State("Waiting"); } }
    }
    //End Enum

    class ClientThread
    {
        private BackgroundWorker bgw = new BackgroundWorker();

        public ClientThread()
        {
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;

            bgw.RunWorkerAsync();

            State.Waiting.ToString();
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        public void Command(int coef)
        {
            Console.WriteLine("The client gave his order.");
            Thread.Sleep(1000 * coef);
        }

        public void Pay(int coef)
        {
            Console.WriteLine("The client is paying.");
            Thread.Sleep(1000 * coef);
        }

        public void CallWaiter()
        {
            Console.WriteLine("The client is calling the waiter.");
            Thread.Sleep(1000);
        }

        public void ChooseDish(int coef) //public void ChooseDish(Recipe recipe, int coef)
        {
            Console.WriteLine("The client chose : INSERT RECIPE");
            Thread.Sleep(1000 * coef);
        }

        public void Eat(int coef)
        {
            Console.WriteLine("The client is eating.");
            Thread.Sleep(1000*coef);
        }
    }
}
