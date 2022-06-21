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
    internal class Room
    {
        public string type { get; set; }
        public double price { get; set; }

        public Room(string type, double price)
        {
            this.type = type;
            this.price = price;
        }
    }
}
