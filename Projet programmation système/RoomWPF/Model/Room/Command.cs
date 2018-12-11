using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomWPF.Model.Room
{
    class Command
    {
        private int ID;
        private static int nextID;
        private List<Recipe> content;

        public Command(List<Recipe> content)
        {
            this.content = content;
            ID = nextID;
            nextID++;
        }

        public Command GetCommand()
        {
            return this;
        }
    }
}
