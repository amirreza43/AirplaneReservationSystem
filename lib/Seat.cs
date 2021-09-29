using System;
using System.ComponentModel.DataAnnotations;

namespace lib
{

    public class Seat{

        public int SeatId{get; set;}
        public decimal price{get; set;}
        public int Row{get; set;}
        public string Column{get; set;}
        public Section Section{get; set;}
        public Passenger Passenger{get; set;}

    }

}