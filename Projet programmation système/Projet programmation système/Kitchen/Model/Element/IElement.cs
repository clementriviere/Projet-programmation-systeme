using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projet_programmation_système.Kitchen.Mode
{
    interface IElement
    {
        Point Move(Point position);
    }
}
