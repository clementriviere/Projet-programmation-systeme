using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_programmation_système.Kitchen.Mode
{
    interface IKitchen
    {
        int Width { get; }
        int Height { get; }
        int ElementCount { get; }
        int EquipementCount { get; }
        List<IElement> Equipements { get; set; }
        List<IElement> Elements { get; set; }

        void AddElement(IElement element);
        void RemoveElement(IElement motion);
        void AddEquipement(IEquipement equipement);
        void RemoveEquipement(IEquipement equipement);
    }
}
