using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room.Model
{
    class Room
    {
        private static Room INSTANCE;
        public static int CAPACITY_ROOM;

        private Room(int capacity)
        {
            Room.CAPACITY_ROOM = 75;
        }

        public Room GetInstance()
        {
            return INSTANCE;
        }
    }
}
