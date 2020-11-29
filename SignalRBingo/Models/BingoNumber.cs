using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRBingo.Models
{
    public class BingoNumber
    {
        
        public bool State { get; set; }
        public int Number { get; set; }
        public BingoNumber(bool state, int number)
        {
            State = state;
            Number = number;
        }

    }
}
