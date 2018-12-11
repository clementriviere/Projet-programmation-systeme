using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomWPF.Model.Client
{
    interface IClient
    { 
        int Coef { get; set; }
        bool NeedBreadAndDrinks { get; set; } //A implémenter

        void Wait();
        void ChooseCommand();
        void Eat();
        void Pay();
        void ModifyTimeScript(int Coef);
    }
}
