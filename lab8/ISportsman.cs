using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    public interface ISportsman
    {
        int Matches { get; set; }
        int Goals { get; set; }
        void PlayMatch();
    }
}
