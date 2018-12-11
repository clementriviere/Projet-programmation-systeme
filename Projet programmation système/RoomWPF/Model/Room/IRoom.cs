using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room.Model
{
    interface IRoom
    {
        int Width { get; set; }
        int Height { get; set; }
        int ElementCount { get; set; }
        int EquipementCount { get; set; }

        //List<IElement> Elements { get; set; }   A changer, voir avec IMotion et IElement ?
        List<IEquipement> Equipements { get; set; }

        //void AddElement(IElement element);

        //void RemoveElement(IElement element);

        void AddEquipement(IEquipement equipement);

        void RemoveEquipement(IEquipement equipement);
    }
}
