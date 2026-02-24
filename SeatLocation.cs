using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal struct SeatLocation
    {
        public char row {  get; set; }
        public int number { get; set; }
        public SeatLocation(char row, int number)
        {
            this.row = row;
            this.number = number;
        }
        public override string ToString()
        {
            return $"{row}-{number}";
        }
    }
}
