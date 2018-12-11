using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomWPF.Model.Client
{
    class SlowClient : IClient
    {
        public int Coef { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool NeedBreadAndDrinks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SlowClient()
        {
            this.Coef = 1/2;
            this.NeedBreadAndDrinks = false;
        }

        public void ChooseCommand()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void ModifyTimeScript(int Coef)
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            throw new NotImplementedException();
        }

        public void Wait()
        {
            throw new NotImplementedException();
        }
    }
}
