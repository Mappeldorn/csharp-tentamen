using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentamen
{
    /// Name: Max Appeldorn
    /// StudentNr: 5049350
    /// Date: 20-06-2022
    internal class Hotel
    {
        public string name { get; set; }
        private List<Room> rooms;

        public Hotel(string name)
        {
            this.name = name;
            this.rooms = new List<Room>();
        }

        public void addRoom(Room room)
        {
            this.rooms.Add(room);
        }


        public List<Room> getRooms()
        {
            return this.rooms;
        }

       public double getRoomPriceByType(string type)
        {
            
            foreach (Room room in this.rooms)
            {

                if (room.type == type)
                {
                    return room.price
                        ;
                }
            }

            return 0.0;

        }
    }
}
